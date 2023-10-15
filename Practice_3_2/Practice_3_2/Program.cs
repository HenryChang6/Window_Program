namespace practice_3_2
{
   
    class Program
    {
        class Member
        {
            public string name;
            public string department;
            public string ID;
            public string level;
            public string title; //預設為無
            public string level_label;
            public Member(string name, string department, string ID)
            {
                this.name = name;
                this.department = department;
                this.ID = ID;
                this.level = "歡迎新社員!!";
                this.title = "無";
                this.level_label = "萌新社員";
            }

        }
        static void Print_Welcome_Message(bool isFirstMessage)
        {
            Console.WriteLine(isFirstMessage ? "-----------------------------### 社員資料登記 ###-----------------------------" : "------------------------------------------------------------------------------");
            Console.WriteLine("新增社員資訊:\t register\tname\tdepartment\tID");
            Console.WriteLine("以特定屬性查詢:  search\tname\ttag\tWant_search_string");
            Console.WriteLine("授予社員職位:\t entitle\tname\tdepartment\tID\tThat_title");
            Console.WriteLine("所有社員列表:\t check");
            Console.WriteLine("指令格式列表:\t help");
            Console.WriteLine("離開此程式:\t exit");
            Console.Write(isFirstMessage ? "" : "------------------------------------------------------------------------------\n");
        }
        public static void Main(string[] args)
        {
            bool isFirstMessage = true;
            Print_Welcome_Message(isFirstMessage);
            isFirstMessage = false;
            List<Member> members = new List<Member>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(" ");
                switch (s[0])
                {
                    case "register":
                        //先尋找是否已經存在
                        bool alreadyExist = false;
                        foreach(Member member in members)
                        {
                            if(member.name == s[1] && member.department == s[2] && member.ID == s[3])
                            {
                                alreadyExist = true;
                                if (member.level == "歡迎新社員!!")
                                {
                                    member.level = "已晉升為資深社員";
                                    member.level_label = "資深社員";
                                    Console.WriteLine(member.level);
                                    alreadyExist = true;
                                    break;
                                }

                                else if (member.level == "已晉升為資深社員")
                                {
                                    member.level = "已晉升為永久社員";
                                    member.level_label = "永久社員";
                                    Console.WriteLine(member.level);
                                    alreadyExist = true;
                                    break;
                                }
                                else if (member.level == "已晉升為永久社員")
                                {
                                    member.level = "已經是永久社員了喔";
                                    Console.WriteLine(member.level);
                                    alreadyExist = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(member.level);
                                    alreadyExist = true;
                                    break;
                                }
                            }
                        }
                        //若不存在 則建立新物件
                        if (!alreadyExist)
                        {
                            Member new_member = new Member(s[1], s[2], s[3]);
                            members.Add(new_member);
                            Console.WriteLine(new_member.level);
                        }
                        break;
                    case "search":
                        if (s[1] == "name")
                        {
                            bool isfound = false;
                            foreach(Member member in members)
                            {
                                if(member.name == s[2])
                                {
                                    Console.WriteLine($"{member.name}\t{member.department}\t{member.ID}\t{member.level_label}\t{member.title}");
                                    isfound = true;
                                }
                            }
                            if (!isfound)
                            {
                                Console.WriteLine("\t\t找不到這個人ㄟ");
                            }
                        }
                        else if (s[1] == "department")
                        {
                            bool isfound = false;
                            foreach (Member member in members)
                            {
                                if (member.department == s[2])
                                {
                                    Console.WriteLine($"{member.name}\t{member.department}\t{member.ID}\t{member.level_label}\t{member.title}");
                                    isfound = true;
                                }
                            }
                            if (!isfound)
                            {
                                Console.WriteLine("\t\t找不到這個系的人ㄟ");
                            }

                        }
                        else if (s[1] == "ID")
                        {
                            bool isfound = false;
                            foreach (Member member in members)
                            {
                                if (member.ID == s[2])
                                {
                                    Console.WriteLine($"{member.name}\t{member.department}\t{member.ID}\t{member.level_label}\t{member.title}");
                                    isfound = true;
                                }
                            }
                            if (!isfound)
                            {
                                Console.WriteLine("\t\t找不到這個學號的人ㄟ");
                            }
                        }
                        else if (s[1] == "level")
                        {
                            bool isfound = false;
                            foreach (Member member in members)
                            {
                                if (member.level_label == s[2])
                                {
                                    Console.WriteLine($"{member.name}\t{member.department}\t{member.ID}\t{member.level_label}\t{member.title}");
                                    isfound = true;
                                }
                            }
                            if (!isfound)
                            {
                                Console.WriteLine("\t\t找不到這個等級的人ㄟ");
                            }
                        }
                        else if (s[1] == "title")
                        {
                            bool isfound = false;
                            foreach (Member member in members)
                            {
                                if (member.title == s[2])
                                {
                                    Console.WriteLine($"{member.name}\t{member.department}\t{member.ID}\t{member.level_label}\t{member.title}");
                                    isfound = true;
                                }
                            }
                            if (!isfound)
                            {
                                Console.WriteLine("\t\t找不到這個職務的人ㄟ");
                            }
                        }
                        break;
                    case "entitle":
                        bool isfound2 = false;
                        foreach(Member member in members)
                        {
                            //找到這個人
                            if (member.name == s[1] && member.department == s[2] && member.ID == s[3])
                            {
                                isfound2 = true;
                                //不能給社長的title
                                if (s[4].Contains("社長"))
                                {
                                    Console.WriteLine("我們的社長只有阿明一個人，你不要想篡位!");
                                }
                                else 
                                {
                                    member.title = s[4];
                                    Console.WriteLine($"{member.name}已晉升為{member.title}!");
                                }
                               
                                break;
                            }
                        }
                        //沒找到人
                        if (!isfound2)
                        {
                            Console.WriteLine("找不到這個人ㄟ");
                        }
                        break;
                    case "check":
                        Console.WriteLine("------------------------------------------------------------------------------");
                        //if沒有社員
                        if(members.Count == 0)
                        {
                            Console.WriteLine("目前沒有社員喔QQ");
                            Console.WriteLine("------------------------------------------------------------------------------");
                            break;
                        }
                        foreach(Member member in members)
                        {
                            Console.WriteLine($"{member.name,-10}{member.department,-15}{member.ID,-15}{member.level_label,-15}{member.title,-10}");
                        }
                        Console.WriteLine("------------------------------------------------------------------------------");
                        break;
                    case "help":
                        Print_Welcome_Message(isFirstMessage);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("不存在這個功能，有疑慮請打help");
                        break;
                }
            }
            Environment.Exit(0);
        }
        
    }
}