using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Parser.cs
 * Defines the Parser class which includes tools for parsing 
 * First created by Ashkan Taravati
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
namespace StudentDataManager
{
    class Parser
    {
        string Buffer;

        Parser()
        {

        }
        Parser(string file)
        {
           Buffer = File.ReadAllText(@file);
           
        }
        /// <summary>
        /// Parses the imported text file to Student objects, then returns list of students.
        /// </summary>
        /// <returns></returns>
        B_Tree Parse()
        {//Format Guide:   strb.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8};", CreateIdentifier(), LastName, FirstName,FathersName,BirthYear.ToString(), BirthMonth.ToString(), BirthDay.ToString());
            B_Tree dc = new B_Tree();
            string[] records = Buffer.Split(';');
            foreach(var record in records)
            {
                Student s = new Student();
                var size = record.Length;
                for(int i=0;i<size;i++)
                {
                    string[] fields = record.Split(',');
                    ParseIdentifier(fields[0]);
                    for (int j = 1; j < fields.Length; j++)
                    {
                        switch (j)
                        {
                            

                            case 1:
                                {
                                    
                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                            case 4:
                                {
                                    break;
                                }
                            case 5:
                                {
                                    break;
                                }
                            case 6:
                                {
                                    break;
                                }
                            case 7:
                                {
                                    break;
                                }
                            case 8:
                                {
                                    break;
                                }
                                
                    }
                    }
                }
            }
            return dc;
        }
        //Tuple<ushort, ushort, ushort, ushort> ParseIdentifier(string id)
        //{

        //    return new Tuple<ushort, ushort, ushort, ushort>(1, 1, 1, 1);
        //}

        void ParseIdentifier(string id)
        {
            ushort entranceYear=0;
            ushort gender=0;
            ushort fieldCode=0;
            ushort studentSerialCode=0;
            //4 digit year:0~3
            //1 digit gender:4
            //2 digit fieldcode:5,6
            //else:7~length
            var arr = id.ToCharArray();
            StringBuilder eys = new StringBuilder();
            for(int i=0;i<4;i++)
            eys.Append(arr[i].ToString());
            entranceYear = ushort.Parse(eys.ToString());
            gender = ushort.Parse(arr[4].ToString());
            fieldCode = ushort.Parse((new StringBuilder().AppendFormat("{0}{1}", arr[5], arr[6])).ToString());
            StringBuilder ssc = new StringBuilder();
            for (int i = 7; i < id.Length; i++)
                ssc.Append(arr[i]);
            studentSerialCode = ushort.Parse(ssc.ToString());




        }
    }
}
