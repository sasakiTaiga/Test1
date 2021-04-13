using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{

    public class Test
    {
        /// <summary>
        /// 教科
        /// </summary>
        public String Subj { get; set; }

        /// <summary>
        /// 点数
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// クラス
        /// </summary>
        public String ClassName { get; set; }
    }

    public class Class1
    {
        // バインディングの指定先プロパティ
        public ObservableCollection<Test> Data { get; }
        public ObservableCollection<Test> Data1 { get; }

        // コンストラクタ(データ入力)
        public Class1()
        {
            Data = new ObservableCollection<Test> {
               new Test { Subj="国語", Points=90, Name="田中　一郎", ClassName="A" },
               new Test { Subj="数学", Points=50, Name="鈴木　二郎", ClassName="A" },
               new Test { Subj="英語", Points=90, Name="佐藤　三郎", ClassName="B" }
           };

            Data1 = new ObservableCollection<Test> {
               new Test { Subj="社会", Points=90, Name="一郎", ClassName="A" },
               new Test { Subj="科学", Points=50, Name="二郎", ClassName="A" },
               new Test { Subj="物理", Points=90, Name="三郎", ClassName="B" }
           };
        }

        public void aaaa()
        {
        }
    }
}
