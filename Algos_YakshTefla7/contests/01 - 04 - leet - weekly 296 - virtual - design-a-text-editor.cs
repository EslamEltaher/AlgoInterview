////1 - 4 https://leetcode.com/contest/weekly-contest-296/
////1 - 4 https://leetcode.com/contest/weekly-contest-296/problems/design-a-text-editor/

//using System;

//public class TextEditor
//{
//    public string content { get; set; }
//    public int cursor { get; set; }

//    public TextEditor()
//    {
//        content = "";
//        cursor = 0;
//    }

//    public void AddText(string text)
//    {
//        string left = content.Substring(0, cursor);
//        string right = content.Substring(cursor, content.Length - cursor);


//        content = left + text + right;
//        cursor += text.Length;

//        //return left.Substring(left.Length - Math.Max(10 - text.Length, 0), Math.Max(10 - text.Length, 0))
//        //    + text.Substring(Math.Max(0, text.Length - 10), Math.Min(10,1));
//    }

//    public int DeleteText(int k)
//    {
//        int deleted = Math.Min(k, cursor);


//        string right = content.Substring(cursor);

//        cursor -= deleted;

//        string left = content.Substring(0, cursor);

//        content = left + right;

//        return deleted;
//    }

//    public string CursorLeft(int k)
//    {
//        cursor = Math.Max(0, cursor - k);
//        return content.Substring(Math.Max(0, cursor - 10), cursor - Math.Max(0, cursor - 10));
//    }

//    public string CursorRight(int k)
//    {
//        cursor = Math.Min(cursor + k, content.Length);
//        return content.Substring(Math.Max(0, cursor - 10), cursor - Math.Max(0, cursor - 10));
//    }
//}

////public class NaiveTextEditor
////    {
////        public string content { get; set; }
////        public int cursor { get; set; }

////        public TextEditor()
////        {
////            content = "";
////            cursor = 0;
////        }

////        public void AddText(string text)
////        {
////            string left = content.Substring(0, cursor);
////            string right = content.Substring(cursor, content.Length - cursor);


////            content = left + text + right;
////            cursor += text.Length;

////            //return left.Substring(left.Length - Math.Max(10 - text.Length, 0), Math.Max(10 - text.Length, 0))
////            //    + text.Substring(Math.Max(0, text.Length - 10), Math.Min(10,1));
////        }

////        public int DeleteText(int k)
////        {
////            int deleted = Math.Min(k, cursor);


////            string right = content.Substring(cursor);

////            cursor -= deleted;

////            string left = content.Substring(0, cursor);

////            content = left + right;

////            return deleted;
////        }

////        public string CursorLeft(int k)
////        {
////            cursor = Math.Max(0, cursor - k);
////            return content.Substring(Math.Max(0, cursor - 10), cursor - Math.Max(0, cursor - 10));
////        }

////        public string CursorRight(int k)
////        {
////            cursor = Math.Min(cursor + k, content.Length);
////            return content.Substring(Math.Max(0, cursor - 10), cursor - Math.Max(0, cursor - 10));
////        }
////}

///**
// * Your TextEditor object will be instantiated and called as such:
// * TextEditor obj = new TextEditor();
// * obj.AddText(text);
// * int param_2 = obj.DeleteText(k);
// * string param_3 = obj.CursorLeft(k);
// * string param_4 = obj.CursorRight(k);
// */

