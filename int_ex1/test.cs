using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace inf_ex1
{
    class Test
        {
            private struct testList
            {
                public bool eng;
                public bool rus;
                public bool dig;
                public string whiteList;
                public string input;
                public string output;
            }

            private static testList[] createTests()
            {
                testList[] tests = new testList[20];
                
                tests[0].eng = false;
                tests[0].rus = false;
                tests[0].dig = false;
                tests[0].whiteList = "";
                tests[0].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[0].output = "";
                
                tests[1].eng = true;
                tests[1].rus = false;
                tests[1].dig = false;
                tests[1].whiteList = "";
                tests[1].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[1].output = "aAbBcC";
                
                tests[2].eng = false;
                tests[2].rus = true;
                tests[2].dig = false;
                tests[2].whiteList = "";
                tests[2].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[2].output = "аАбБвВ";
                
                tests[3].eng = false;
                tests[3].rus = false;
                tests[3].dig = true;
                tests[3].whiteList = "";
                tests[3].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[3].output = "123";
                
                tests[4].eng = false;
                tests[4].rus = false;
                tests[4].dig = false;
                tests[4].whiteList = "<>";
                tests[4].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[4].output = "<>";
                
                tests[5].eng = true;
                tests[5].rus = true;
                tests[5].dig = false;
                tests[5].whiteList = "";
                tests[5].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[5].output = "aAbBcCаАбБвВ";
                
                tests[6].eng = true;
                tests[6].rus = false;
                tests[6].dig = true;
                tests[6].whiteList = "";
                tests[6].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[6].output = "aAbBcC123";
                
                tests[7].eng = false;
                tests[7].rus = true;
                tests[7].dig = true;
                tests[7].whiteList = "";
                tests[7].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[7].output = "аАбБвВ123";
                
                tests[8].eng = false;
                tests[8].rus = false;
                tests[8].dig = false;
                tests[8].whiteList = "abcdef!";
                tests[8].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[8].output = "abc!";
                
                tests[9].eng = false;
                tests[9].rus = false;
                tests[9].dig = false;
                tests[9].whiteList = "BБ,/";
                tests[9].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[9].output = "BБ,/";
                
                tests[10].eng = true;
                tests[10].rus = false;
                tests[10].dig = false;
                tests[10].whiteList = "BБ,/";
                tests[10].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[10].output = "aAbBcCБ,/";
                
                tests[11].eng = false;
                tests[11].rus = true;
                tests[11].dig = false;
                tests[11].whiteList = "BБ,/";
                tests[11].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[11].output = "BаАбБвВ,/";
                
                tests[12].eng = false;
                tests[12].rus = false;
                tests[12].dig = true;
                tests[12].whiteList = "BБ,/";
                tests[12].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[12].output = "BБ123,/";
                
                tests[13].eng = true;
                tests[13].rus = true;
                tests[13].dig = true;
                tests[13].whiteList = "";
                tests[13].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[13].output = "aAbBcCаАбБвВ123";
                
                tests[14].eng = true;
                tests[14].rus = true;
                tests[14].dig = false;
                tests[14].whiteList = "2";
                tests[14].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[14].output = "aAbBcCаАбБвВ2";
                
                tests[15].eng = false;
                tests[15].rus = false;
                tests[15].dig = false;
                tests[15].whiteList = "1234567/<>";
                tests[15].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[15].output = "123<>/";
                
                tests[16].eng = false;
                tests[16].rus = true;
                tests[16].dig = false;
                tests[16].whiteList = "";
                tests[16].input = " a A b B c C а А б Б в В 1 2 3 < > ? ! . , / ";
                tests[16].output = "а А б Б в В";
                
                tests[17].eng = true;
                tests[17].rus = false;
                tests[17].dig = false;
                tests[17].whiteList = "?";
                tests[17].input = "a     AbBcCа   АбБ    вВ123    <>?!.,/";
                tests[17].output = "a AbBcC ?";
                
                tests[18].eng = false;
                tests[18].rus = false;
                tests[18].dig = false;
                tests[18].whiteList = "aAbBcCаАбБвВ123<>?!.,/";
                tests[18].input = "aAbBcCаАбБвВ123<>?!.,/";
                tests[18].output = "aAbBcCаАбБвВ123<>?!.,/";
                
                tests[19].eng = true;
                tests[19].rus = true;
                tests[19].dig = true;
                tests[19].whiteList = "<>?!";
                tests[19].input = "";
                tests[19].output = "";
                
                // tests[20].eng = false;
                // tests[20].rus = false;
                // tests[20].dig = false;
                // tests[20].whiteList = "";
                // tests[20].input = "aAbBcCаАбБвВ123<>?!.,/";
                // tests[20].output = "";
                
                return tests;
            }
            public static void runTest(bool show = false)
            {
                testList[] tests = createTests();
                int i = 0;
                foreach (var item in tests)
                {
                    var result = test(item.eng, item.rus, item.dig, item.whiteList, item.input, item.output);
                    Console.WriteLine($"Test {i++}: {result.Key}\nTime: {result.Value}ms");
                    if (show)
                    {
                        string t;
                        if (item.whiteList.Length > 0) t = '\"' + item.whiteList + '\"';
                        else t = "None";
                        // item.whiteList.Length > 0 ? t = item.whiteList : t = "None";
                        Console.WriteLine($"config: end={item.eng}; rus={item.rus}; dig={item.dig}; whiteList={t}\ninput: {item.input}\noutput: {item.output}\n\n");
                    }
                    else Console.WriteLine("\n");
                }
            }
            private static KeyValuePair<bool, long> test(bool eng, bool rus, bool dig, string whiteList, string input, string output)
            {
                bool flag = false;
                Stopwatch stopwatch = new Stopwatch();
                Program.textFormat f = new Program.textFormat(eng, rus, dig, whiteList);
                stopwatch.Start();
                if (f.format(input) == output) flag = true;
                stopwatch.Stop();
                var result = new KeyValuePair<bool, long>(flag, stopwatch.ElapsedMilliseconds);
                return result;
            }
        }
}