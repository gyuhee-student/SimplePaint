using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;



namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle } // 사용할 도형 타입
        private Bitmap canvasBitmap; // 실제 그림이 저장되는 비트맵private Graphics canvasGraphics; // 비트맵 위에 그리기 위한객체private bool isDrawing = false; // 현재 드래그 중인지 여부private Point startPoint; // 드래그 시작점
        private Point endPoint; // 드래그 끝점
        private ToolType currentTool = ToolType.Line; // 현재 선택된 도형private Color currentColor = Color.Black; // 현재 색상
        private int currentLineWidth = 2; // 현재 선 두께


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {

        }

        private void gbxShape_Enter(object sender, EventArgs e)
        {

        }

        private void gbxColor_Enter(object sender, EventArgs e)
        {

        }

        private void gbxdukke_Enter(object sender, EventArgs e)
        {

        }
    }
}
