using System;
using System.Collections.Generic;
using static Practice2_1.Program;
using static System.Net.Mime.MediaTypeNames;

namespace Practice2_1
{
    class Program
    {
        public static class Global
        {
            public static List<course_info> my_course = new List<course_info>();
        }
        static string[] Print_Intro_and_Receive_Command()
        {

            Console.WriteLine("## 成績計算器 ##");
            Console.WriteLine("1. 新增科目(create)");
            Console.WriteLine("2. 刪除科目(delete)");
            Console.WriteLine("3. 更新科目(update)");
            Console.WriteLine("4. 列印成績單(print)");
            Console.WriteLine("5. 退出選單(exit)");
            Console.Write("輸入要執行的指令操作:");

            string command = (Console.ReadLine()).Trim();
            string[] commands = command.Split(' ');
            return commands;
        }
        static bool Check_Exception(string[] commands)
        {
            switch (commands[0])
            {
                // [新增科目] 輸入檢查
                case "create":
                case "update":
                    if(commands.Length < 4)
                    {
                        Console.WriteLine("指令格式不符! 請重新輸入!\n");
                        return true;
                    }
                    int score = Convert.ToInt32(commands[2]);
                    int credits = Convert.ToInt32(commands[3]);
                    // [2]分數 
                    if (score < 0 || score > 100)
                    {
                        Console.WriteLine("成績分數異常! 請重新輸入!\n");
                        return true;
                    }
                    // [3] 學分數
                    else if (credits < 0 || credits > 10)
                    {
                        Console.WriteLine("學分數異常! 請重新輸入!\n");
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "delete":
                    if(commands.Length < 2)
                    {
                        Console.WriteLine("指令格式不符! 請重新輸入!\n");
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "print":
                    return false;
                case "exit":
                    return false;
                default:
                    Console.WriteLine("指令格式不符! 請重新輸入!\n");
                    return false;
                    
            }
     
        } 
        static string Determine_Rank(int score)
        {
            if (score >= 0 && score <= 59) return "F";
            else if (score >= 60 && score <= 62) return "C-";
            else if (score >= 63 && score <= 66) return "C";
            else if (score >= 67 && score <= 69) return "C+";
            else if (score >= 70 && score <= 72) return "B-";
            else if (score >= 73 && score <= 76) return "B";
            else if (score >= 77 && score <= 79) return "B+";
            else if (score >= 80 && score <= 84) return "A-";
            else if (score >= 85 && score <= 89) return "A";
            else return "A+";
        }

        static double[] Determine_GPA_Point(int score)
        {
            //First one is for old, second one is for new.
            if(score >= 0 && score <= 49) return new double[] { 0, 0 };
            else if (score >= 50 && score <= 59) return new double[] {1, 0};
            else if (score >= 60 && score <= 62) return new double[] {2, 1.7};
            else if (score >= 63 && score <= 66) return new double[] { 2, 2.0};
            else if (score >= 67 && score <= 69) return new double[] { 2, 2.3};
            else if (score >= 70 && score <= 72) return new double[] { 3, 2.7};
            else if (score >= 73 && score <= 76) return new double[] { 3, 3.0};
            else if (score >= 77 && score <= 79) return new double[] { 3, 3.3};
            else if (score >= 80 && score <= 84) return new double[] { 4, 3.7};
            else if (score >= 85 && score <= 89) return new double[] { 4, 4.0};
            else return new double[] { 4, 4.3};
        }
        static void Create_Handler(string[] commands)
        {
            //確認該科目是否存在
            if (Global.my_course.Exists((e) => e.course_code == commands[1]))
            {
                Console.WriteLine("科目已存在\n");
                return;
            }
            course_info data_obj = new course_info();
            data_obj.course_code = commands[1];
            data_obj.course_score = Convert.ToInt32(commands[2]);
            data_obj.course_credit = Convert.ToInt32(commands[3]);
            data_obj.course_rank = Determine_Rank(data_obj.course_score);
            data_obj.course_oGPA_point = Determine_GPA_Point(data_obj.course_score)[0];
            data_obj.course_nGPA_point = Determine_GPA_Point(data_obj.course_score)[1];
            Global.my_course.Add(data_obj);
            Console.WriteLine("科目已新增\n");
            return;
        }
        
        static void Delete_Handler(string[] commands)
        {
            //確認該科目是否存在
            if (Global.my_course.Exists((e) => e.course_code == commands[1]))
            {
                var delete_obj = Global.my_course.Find((e) => e.course_code == commands[1]);
                Global.my_course.Remove(delete_obj);
                Console.WriteLine("科目已刪除\n");
                return;
            }
            else
            {
                Console.WriteLine("科目不存在\n");
                return;
            }
        }

        static void Update_Handler(string[] commands)
        {
            if (!Global.my_course.Exists((e) => e.course_code == commands[1]))
            {
                Console.WriteLine("科目不存在");
                return;
            }
            else
            {
                int index = Global.my_course.FindIndex((e) => e.course_code == commands[1]);
                course_info data_obj = new course_info();
                data_obj.course_code = commands[1];
                data_obj.course_score = Convert.ToInt32(commands[2]);
                data_obj.course_credit = Convert.ToInt32(commands[3]);
                data_obj.course_rank = Determine_Rank(data_obj.course_score);
                data_obj.course_oGPA_point = Determine_GPA_Point(data_obj.course_score)[0];
                data_obj.course_nGPA_point = Determine_GPA_Point(data_obj.course_score)[1];
                Global.my_course[index] = data_obj;
                Console.WriteLine("科目已更新\n");
            }
        }

        static void Print_Handler()
        {
            Console.WriteLine("編號  科目代碼  分數  等第  學分數");
            Global.my_course.Sort((c1, c2) => c2.course_score - c1.course_score);
            int index = 1, valid_credits = 0;
            double total_credits = 0, total_score_avg = 0, total_score_OGPA = 0, total_score_NGPA = 0;
            double avg = 0, old_GPA = 0, new_GPA = 0;
            foreach (var course in Global.my_course)
            {
                //output course info
                string output = $"{index,-6}{course.course_code,-10}{course.course_score,-8}{course.course_rank,-8}{course.course_credit,-8}";
                Console.WriteLine(output);
                index++;
                //AVG counting
                total_credits += course.course_credit;
                total_score_avg += course.course_credit * course.course_score;
                // Old GPA counting
                total_score_OGPA += course.course_oGPA_point * course.course_credit;
                //New GPA Counting
                total_score_NGPA += course.course_nGPA_point * course.course_credit;
                //Check valid credits
                if(course.course_score >= 60) valid_credits += course.course_credit;
            }
            avg = Math.Round((total_score_avg / total_credits), 2);
            old_GPA = Math.Round((total_score_OGPA / total_credits), 1);
            new_GPA = Math.Round((total_score_NGPA / total_credits), 1);

            Console.WriteLine($"總平均: {avg}");
            Console.WriteLine($"GPA: {old_GPA}/4.0 (舊制), {new_GPA}/4.3 (新制)");
            Console.WriteLine($"實拿學分數/總學分數: {valid_credits}/{total_credits}\n");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string[] commands = Print_Intro_and_Receive_Command();
                if(Check_Exception(commands)) continue;
                switch (commands[0])
                {
                    case "create":
                        Create_Handler(commands); 
                        break;
                    case "delete":
                        Delete_Handler(commands);
                        break;
                    case "update":
                        Update_Handler(commands);
                        break;
                    case "print":
                        Print_Handler();
                        break;
                    case "exit":
                        Console.WriteLine("離開成績計算機");
                        System.Environment.Exit(0); 
                        break;
                }
            }
            
        }
        public struct course_info
        {
            public string course_code;
            public int course_score;
            public int course_credit;
            public string course_rank;
            public double course_oGPA_point;
            public double course_nGPA_point;
        }
    }
}