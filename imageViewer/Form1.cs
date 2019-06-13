﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace imageViewer
{
    public partial class Form1 : Form
    {
        int imgCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowImage();
        }

        private void ShowImage()
        {
            this.picImg.Image = this.imgList.Images[this.imgCount];
            this.lblNum.Text = (this.imgCount + 1) + "/" + this.imgList.Images.Count;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            this.imgCount--;
            if (this.imgCount < 0)
            {
                this.imgCount = this.imgList.Images.Count-1;
                //this.imgList.Images.Count = 43
                //배열은 0~42만 존재함
            }
            ShowImage();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.imgCount++;
            if (this.imgCount >= this.imgList.Images.Count)
            {
                this.imgCount = 0;
            }
            ShowImage();
        }
    }
}
