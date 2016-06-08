using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Student.cs
 * Contains class definition for Student Class,
 * which is used as the fundamental data type in this application
 * 
 * First Created by Ashkan Taravati 
 * 
 *
 *
 */
namespace StudentDataManager
{
    class Student
    {
       public ushort Gender;//0 for female 1 for male
       public ushort EntranceYear;//4 digits
       public ushort FieldCode;//2 digits
       public ushort StudentIndex;
       public string FirstName;
       public string LastName;
       public string FathersName;
       public ushort BirthYear;
       public ushort BirthMonth;
       public ushort BirthDay;
       public string NationalId;

        /// <summary>
        /// This method will generate a Unique Identifier for the record.
        /// </summary>
        /// <returns></returns>
        string CreateIdentifier()
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendFormat("{0}{1}{2}{3}", EntranceYear.ToString(), Gender.ToString(), FieldCode.ToString(), StudentIndex.ToString());


            return strb.ToString();
        }
        /// <summary>
        /// This method will export record fields as string, which can be later used to write to file.
        /// Comma will seperate fields.
        /// Semicolon will seperate Records.
        /// Example: 13931225820,Taravati,Ashkan,Jamal,1374,07,30,0018535240;
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8};", CreateIdentifier(), LastName, FirstName,FathersName,BirthYear.ToString(), BirthMonth.ToString(), BirthDay.ToString());
            return strb.ToString();
        }
        /// <summary>
        ///  This method will set data to fields.
        ///  NationalId can remain empty.
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="entranceYear"></param>
        /// <param name="fieldCode"></param>
        /// <param name="studentIndex"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="fatherName"></param>
        /// <param name="birthYear"></param>
        /// <param name="birthMonth"></param>
        /// <param name="birthDay"></param>
        /// <param name="nationalId"></param>
        public void SetFields(ushort gender,ushort entranceYear,ushort fieldCode,ushort studentIndex,string firstName,string lastName,string fatherName,ushort birthYear,ushort birthMonth,ushort birthDay,string nationalId="")
           
        {
            Gender = gender;
            EntranceYear = entranceYear;
            FieldCode = fieldCode;
            StudentIndex = studentIndex;
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
            NationalId = nationalId;
        }
        
        

    }
}
