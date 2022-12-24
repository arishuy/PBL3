﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.View
{
    public partial class ItemFood : UserControl
    {
        public MonAn monAn { get; set; }
        public ItemFood(String id_MonAn)
        {
            this.monAn = BLLMonAn.Instance.GetById(id_MonAn);
            InitializeComponent();
            LoadImage();
            lbl_name.Text = this.monAn.TenMonAn;
            lbl_price.Text = "₫" + this.monAn.GiaBan.ToString("#,#");
            lblAmount.Text = this.monAn.SoLuong.ToString();
            checkOutOfStock();
        }
        private int count = 0;
        public event ItemValueChangedEventHandler itemValueChanged;
        public int CountAdded
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
                if (this.count > 0)
                {
                    btnMinus.Visible = true;
                }
                else
                {
                    btnMinus.Visible = false;
                }
                lblSelected.Text = value.ToString();
            }
        }
        
        public void LoadImage()
        {
            Image image;
            using (var bmpTemp = new Bitmap(this.monAn.imagePath))
            {
                image = new Bitmap(bmpTemp);
            }
            pic_food.Image = image;
        }
   
        public void checkOutOfStock()
        {
            if(count < this.monAn.SoLuong)
            {
                lblOutOfStock.Visible = false;
                btnAdd.Visible = true;
            }
            else
            {
                lblOutOfStock.Visible = true;
                btnAdd.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.CountAdded += 1;
            ItemValueChangedEventArgs myArgs = new ItemValueChangedEventArgs(this.monAn.GiaBan, true, this.CountAdded);
            this.itemValueChanged(sender, myArgs);
            checkOutOfStock();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (this.CountAdded > 0)
            {
                this.CountAdded -= 1;
                ItemValueChangedEventArgs myArgs = new ItemValueChangedEventArgs(this.monAn.GiaBan, false, this.CountAdded);
                this.itemValueChanged(sender, myArgs);
                checkOutOfStock();
            }
        }

        public delegate void ItemValueChangedEventHandler(object sender, ItemValueChangedEventArgs e);
        public class ItemValueChangedEventArgs : EventArgs
        {
            private double value;
            private int numOrder;
            private bool isAdd;

            public ItemValueChangedEventArgs(double _value, bool _isAdd, int _numOrder)
            {
                this.value = _value;
                this.isAdd = _isAdd;
                this.numOrder = _numOrder;
            }

            public double Value { get { return this.value; } }
            public int NumOrder { get { return this.numOrder; } }
            public bool IsAdd { get { return this.isAdd; } }

        }
    }
}
