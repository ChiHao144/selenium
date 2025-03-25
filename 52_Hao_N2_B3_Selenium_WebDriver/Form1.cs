using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace _52_Hao_N2_B3_Selenium_WebDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Open_52_Hao_Click(object sender, EventArgs e)
        {
            // dieu huong trinh duyet
            //bai 1: 52_Hao dieu huong den trang google
            IWebDriver driver_52_Hao = new ChromeDriver();
            driver_52_Hao.Navigate().GoToUrl("https://www.google.com/");        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_url_52_hao_Click(object sender, EventArgs e)
        {
            //Bai 2: Dieu huong den 1 trang web VnEpress bang cach go vao textbox
            IWebDriver drive_52_Hao = new ChromeDriver();
            drive_52_Hao.Url = txt_url_52_Hao.Text;
            drive_52_Hao.Navigate();
        }

        // Khai báo biến toàn cục cho IWebDriver
        private IWebDriver driver_52_Hao;

        private void btn_notext_url_52_Hao_Click(object sender, EventArgs e)
        {
            // Bài 3 a: Không nhập url, nhấn open url, textbox sẽ nhận url mà bạn code
            driver_52_Hao = new ChromeDriver();
            driver_52_Hao.Navigate().GoToUrl("http://vnexpress.net");
        }

        private void btn_Close_52_hao_Click(object sender, EventArgs e)
        {
            // Bài 3 b: Close trình duyệt 
            driver_52_Hao = new ChromeDriver();
            driver_52_Hao.Close();
        }

        private void btn_CloseMHDen_52_Hao_Click(object sender, EventArgs e)
        {
            //Bai 3 c: tat man hinh den
            ChromeDriverService chrome_52_Hao = ChromeDriverService.CreateDefaultService();
            chrome_52_Hao.HideCommandPromptWindow = true;
            //dieu huong trinh duyet
            IWebDriver driver_52_Hao = new ChromeDriver(chrome_52_Hao);
            driver_52_Hao.Navigate().GoToUrl("http://vnexpress.net");

            //Bai 3 e: lay url
            String link_hien_tai_52_Hao = driver_52_Hao.Url;
            Console.WriteLine(link_hien_tai_52_Hao);
        }

        private void btn_CloseAllWindow_52_Hao_Click(object sender, EventArgs e)
        {
            //Bai 3 d: Tat moi cua so lien ket
            driver_52_Hao = new ChromeDriver();
            driver_52_Hao.Quit();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_lay_title_52_Hao_Click(object sender, EventArgs e)
        {
            //Bai 3 f: lay title
            //Dieu huong den 1 trinh duyet
            driver_52_Hao = new ChromeDriver();
            driver_52_Hao.Navigate().GoToUrl("http://vnexpress.net");
            //lay title
            String urlTile_52_hao = driver_52_Hao.Title;
            txt_hien_thi_52_Hao.Text = urlTile_52_hao;
        }

        private void txt_hien_thi_52_Hao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_lay_pagesource_52_Hao_Click(object sender, EventArgs e)
        {
            //Bai 3 g: lay pagesource
            //Dieu huong den 1 trinh duyet
            driver_52_Hao = new ChromeDriver();
            driver_52_Hao.Navigate().GoToUrl("http://vnexpress.net");
            //Lay page source
            String PageSource_52_hao = driver_52_Hao.PageSource;
            Console.WriteLine(PageSource_52_hao);
        }

        private void btn_Back_Forward_52_Hao_Click(object sender, EventArgs e)
        {
            //Bai 3 h: back forward
            //Dieu huong den 1 trinh duyet
            driver_52_Hao = new ChromeDriver();
            driver_52_Hao.Navigate().GoToUrl("http://vnexpress.net");
            Thread.Sleep(1000);
            driver_52_Hao.Navigate().GoToUrl("http://ou.edu.vn/");
            Thread.Sleep(5000);
            driver_52_Hao.Navigate().Back();
            Thread.Sleep(1000);
            driver_52_Hao.Navigate().Forward();
            Thread.Sleep(1000);
            driver_52_Hao.Navigate().Refresh();
        }
    }
}
