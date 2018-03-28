using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xpath.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //            /bookstore/book[1]     选取属于 bookstore 子元素的第一个 book 元素。
            ///bookstore/book[last()]     选取属于 bookstore 子元素的最后一个 book 元素。
            ///bookstore/book[last()-1]     选取属于 bookstore 子元素的倒数第二个 book 元素。
            ///bookstore/book[position()<3]     选取最前面的两个属于 bookstore 元素的子元素的 book 元素。
            ////title[@lang]     选取所有拥有名为 lang 的属性的 title 元素。
            ////title[@lang='eng']     选取所有 title 元素，且这些元素拥有值为 eng 的 lang 属性。
            ///bookstore/book[price>35.00]     选取 bookstore 元素的所有 book 元素，且其中的 price 元素的值须大于 35.00。
            ///bookstore/book[price>35.00]/title     选取 bookstore 元素中的 book 元素的所有 title 元素，且其中的 price 元素的值须大于 35.00。
        }
    }
}
