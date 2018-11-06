﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTCU
{
    public partial class Instructions : Form
    {
        bool hidden;
        Image pufflesImage;
        Image organsImage;
        Image dragImage;
        Image classroomImage;
        Image memoryImage;

        public Instructions()
        {
            InitializeComponent();
            hidden = false;
            pufflesImage = Properties.Resources.pufflesInstruction;
            organsImage = Properties.Resources.organsInstruction;
            dragImage = Properties.Resources.dragwordsInstruction;
            classroomImage = Properties.Resources.classroomInstruction;
            memoryImage = Properties.Resources.memoryInstructions;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            hidden = true;
        }

        public void puffles()
        {
            pictureBox1.Image = pufflesImage;
            label1.Text = "Click the sound button.";
            label2.Text = "Click and drag.";
            label3.Text = "Choose the correct color.";
        }

        public void classroom()
        {
            pictureBox1.Image = classroomImage;
            label1.Text = "Click the sound button.";
            label2.Text = "";
            label3.Text = "Choose the right object.";
        }

        public void organs()
        {
            pictureBox1.Image = organsImage;
            label1.Text = "Click the sound button.";
            label2.Text = "Listen and read.";
            label3.Text = "Choose the right organ.";
        }

        public void dragwords()
        {
            pictureBox1.Image = dragImage;
            label1.Text = "Drag the words.";
            label2.Text = "Order them.";
            label3.Text = "Check answer.";
        }

        public void memory()
        {
            pictureBox1.Image = memoryImage;
            label1.Text = "Click on a Image.";
            label2.Text = "Click on other Image.";
            label3.Text = "Try to match.";
        }

    }
}