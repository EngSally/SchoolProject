
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.EntityManagers;

namespace SchoolProject
{
    public partial class TopicForm : Form
    {
        bool newTopicFlag;
        public TopicForm()
        {
            InitializeComponent();
            LongestCommonPrefix();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            newTopicFlag = true;
            txtTobicName.Text = "";
            txtTobicName.ReadOnly = false;
        }

        private void TopicForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TopicManger.LoadAllTopic();
            //dataGridView1.databi
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(newTopicFlag)
            {
                //TopicBusiness.InsertNewTopic(txtTobicName.Text);
                //dataGridView1.DataSource = TopicBusiness.LoadAllTopic();
                //txtTobicName.ReadOnly = true ;
            }
            else
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string LongestCommonPrefix()
        {
            string[] strs = { "dog", "racecar", "car" };
            int countWords = strs.Count();
            Dictionary<char,int> dic = new Dictionary<char,int>();
            foreach(string word in strs)
            {
                foreach(char c in word)
                {
                   if(! dic.TryAdd(c, 1))
                    {
                      if(  word.Count(k=>k==c)==1)
                       dic[c]= dic[c]+1;
                    }
                }
            }
            //(x => x.Value == "one").Key
            string output = "";
            var repetchar=   dic.Where(x => x.Value == countWords);
            foreach(var  pair in repetchar)
            {
                output += pair.Key;
            }
            return output;
        }
    }
}
