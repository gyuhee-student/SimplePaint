using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle } // 사용할 도형 타입

        private Bitmap canvasBitmap; // 실제 그림이 저장되는 비트맵
        private Graphics canvasGraphics; // 비트맵 위에 그리기 위한 객체
        private bool isDrawing = false; // 현재 드래그 중인지 여부

        private Point startPoint; // 드래그 시작점
        private Point endPoint; // 드래그 끝점

        private ToolType currentTool = ToolType.Line; // 현재 선택된 도형
        private Color currentColor = Color.Black; // 현재 색상
        private int currentLineWidth = 2; // 현재 선 두께
        private float zoomScale = 1.0f; // 현재 확대/축소 비율

        public Form1()
        {
            InitializeComponent();

            // 캔버스 초기화
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White); // 캔버스를 흰색으로 초기화
            picCanvas.Image = canvasBitmap; // 그린 그림을 화면(PictureBox)에 표시

            // 마우스 이벤트 연결
            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;

            // picCanvas가 다시 그려질 때 PicCanvas_Paint 함수를 실행하도록 연결
            picCanvas.Paint += PicCanvas_Paint;

            // 도형 선택 버튼 이벤트 연결
            btnLine.Click += btnLine_Click;
            btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;

            // 파일 열기와 확대/축소 버튼 이벤트 연결
            btnOpenFile.Click += btnOpenFile_Click;
            btnZoomOut.Click += btnZoomOut_Click;
            btnZoomIn.Click += btnZoomIn_Click;

            // 색상 콤보박스 이벤트 연결
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 0; // 기본값: Black

            // 선 두께 트랙바 이벤트 연결
            trbLineWidth.Minimum = 1; // 최소값
            trbLineWidth.Maximum = 10; // 최대값
            trbLineWidth.Value = 5;
            currentLineWidth = trbLineWidth.Value;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {

        }

        private void btnSaveFile_Click(object? sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "그림 저장";
            saveFileDialog.Filter = "PNG 이미지 (*.png)|*.png|JPG 이미지 (*.jpg)|*.jpg|BMP 이미지 (*.bmp)|*.bmp";
            saveFileDialog.FileName = "simplepaint";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            ImageFormat imageFormat = saveFileDialog.FilterIndex switch
            {
                1 => ImageFormat.Png,
                2 => ImageFormat.Jpeg,
                3 => ImageFormat.Bmp,
                _ => ImageFormat.Png
            };

            canvasBitmap.Save(saveFileDialog.FileName, imageFormat);
        }

        private void btnOpenFile_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "그림 열기";
            openFileDialog.Filter = "이미지 파일 (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using Image loadedImage = Image.FromFile(openFileDialog.FileName);
            Bitmap loadedBitmap = new Bitmap(loadedImage);
            SetCanvasBitmap(loadedBitmap);
        }

        private void PicCanvas_MouseDown(object? sender, MouseEventArgs e)
        {
            isDrawing = true; // 드래그 시작
            startPoint = GetCanvasPoint(e.Location); // 시작점 저장
        }

        private void PicCanvas_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!isDrawing) return; // 그림 그리기와 상관 없는 마우스 움직임은 무시

            endPoint = GetCanvasPoint(e.Location); // 현재 위치 갱신

            // picCanvas를 다시 그려라 (Paint 이벤트를 발생시킨다)
            picCanvas.Invalidate(); // 화면 다시 그리기 (미리보기)
        }

        private void PicCanvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (!isDrawing) return; // 그림 그리기와 상관 없는 마우스 움직임은 무시

            isDrawing = false; // 드래그 종료
            endPoint = GetCanvasPoint(e.Location);

            // 실제 비트맵에 도형 그리기 (확정)
            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }

            picCanvas.Invalidate(); // 다시 그려서 결과 반영, Paint 이벤트 발생
        }

        private void PicCanvas_Paint(object? sender, PaintEventArgs e)
        {
            if (!isDrawing) return;

            // 점선 펜 (미리보기용)
            using (Pen previewPen = new Pen(currentColor, currentLineWidth))
            {
                previewPen.DashStyle = DashStyle.Dash;
                e.Graphics.ScaleTransform(zoomScale, zoomScale);
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }

        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);

            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;

                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;

                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y)
            );
        }

        private void btnLine_Click(object? sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }

        private void btnRectangle_Click(object? sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        private void btnCircle_Click(object? sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

        private void cmbColor_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: // Black 검정
                    currentColor = Color.Black;
                    break;

                case 1: // Red 빨강
                    currentColor = Color.Red;
                    break;

                case 2: // Blue 파랑
                    currentColor = Color.Blue;
                    break;

                case 3: // Green 녹색
                    currentColor = Color.Green;
                    break;

                default:
                    currentColor = Color.Black;
                    break;
            }
        }

        private void trbLineWidth_ValueChanged(object? sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }

        private void btnZoomOut_Click(object? sender, EventArgs e)
        {
            if (zoomScale <= 0.25f) return;

            zoomScale -= 0.25f;
            UpdateCanvasView();
        }

        private void btnZoomIn_Click(object? sender, EventArgs e)
        {
            if (zoomScale >= 3.0f) return;

            zoomScale += 0.25f;
            UpdateCanvasView();
        }

        private void SetCanvasBitmap(Bitmap newBitmap)
        {
            picCanvas.Image = null;
            canvasGraphics.Dispose();
            canvasBitmap.Dispose();

            canvasBitmap = newBitmap;
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            picCanvas.Image = canvasBitmap;

            zoomScale = 1.0f;
            UpdateCanvasView();
        }

        private void UpdateCanvasView()
        {
            picCanvas.Size = new Size(
                (int)(canvasBitmap.Width * zoomScale),
                (int)(canvasBitmap.Height * zoomScale)
            );

            lblZoomRate.Text = $"{(int)(zoomScale * 100)}%";
            picCanvas.Invalidate();
        }

        private Point GetCanvasPoint(Point mousePoint)
        {
            return new Point(
                Math.Clamp((int)(mousePoint.X / zoomScale), 0, canvasBitmap.Width - 1),
                Math.Clamp((int)(mousePoint.Y / zoomScale), 0, canvasBitmap.Height - 1)
            );
        }
    }
}
