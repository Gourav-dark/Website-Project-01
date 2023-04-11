using System;
namespace project_01{
    public class Program{
        public static void Main(string[] args){
            Console.WriteLine("Enter Card No.: ");
            string cardno=Console.ReadLine();
            if(ValidateCard(cardno)){
                Console.WriteLine($"{cardno} is Valid");
            }else
                Console.WriteLine($"{cardno} is Invalid");
        }
        public static bool ValidateCard(string cno){
            int len=cno.Length;
            int s1=0,s2=0,s3=0;
            if(len>=13 && len<=16){
                if(cno.Substring(0,1)=="4"||cno.Substring(0,1)=="5"||cno.Substring(0,1)=="6"||cno.Substring(0,1)=="36")
                {
                    char[] ncno = cno.ToCharArray();
                    Array.Reverse(ncno);
                    for(int i=1;i<=len;i++){
                        int temp= (int)Char.GetNumericValue(ncno[i-1]);
                        if(i%2==0){
                            if(temp*2<10){
                                s1=s1+temp*2;
                            }else{
                                temp=temp*2;
                                int a=temp%10;
                                int b=temp/10;
                                s1=s1+a+b;
                            }
                        }
                        else{
                            s2=s2+temp;
                        }
                    }
                    s3=s1+s2;
                    if(s3%10==0){
                        return true;
                    }else{
                        return false;
                    }
                }else{
                    return false;
                }
            }
            else{
                return false;
            }
        }
    }
}
//5196081888500645
