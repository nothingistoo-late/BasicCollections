using PrimitiveList.Entities;
using System.Collections;

namespace PrimitiveList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PlayWithPrimitiveListV2();
            PlayWithStudentList();
        }

        static void PlayWithStudentList()
        {
            // y chang với Cabinet<Student> tuSE = new Cabinet<>();
            // tuSE.add(new Student(){});
            List<Student> tuSE = new List<Student>();  
            tuSE.Add(new Student() { });
            tuSE.Add(new Student() { });
            tuSE.Add(new Student() { });

            Console.WriteLine("The List of Students");
            foreach (var x in tuSE)
            {
                Console.WriteLine(x.Name);
                Console.WriteLine(x);// gọi thầm tên em
            }
        }

        static void PlayWithPrimitiveListV2()
        {
            // hàng chuẩn, chơi List<GENERIC để kh lộn xộn trong vùng new>
            List<int> arr = new List<int>();
            // túi, hộp arr chỉ chứa dc int, cấm đưa lộn xộn, chửi liền
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            //arr.Add("Hello"); chửi vì kh cùng data type
            // in list
            Console.WriteLine("The Size := " + arr.Count); // 3 biến 3 value ~ mảng 3 biến int
            // nhưng còn mở rộng thêm

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The List Printed by using for i");
            for (int i = 0; i < arr.Count; i++)
            {
               // Console.WriteLine(arr[i]);//xài như mảng nếu muốn get(i)
                Console.WriteLine(arr.ElementAt(i)); // giống .get(i)
            }
        }
        static void PlayWithPrimitiveList()
        {
            // Cabinet arr = new Cabinet();
            // arr.AddStudent(...); arr.AddLecturer(...)
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(10);
            arr.Add("Hello");
            arr.Add(3.14);
            arr.Add(true);
            arr.Add(new Student() { });
            Console.WriteLine($"There is/are {arr.Count} Item(s) := ");
            //for each thẳng tiến nếu mún, for count dc
            // xóa là xóa luôn
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The List Printed By For i");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);// get phần tử thứ i dùng như mảng [i]
                // java là get(index) hàm
            }
            
        }
    }
}
// để lưu nhiều dữ liêu (primitive, object) trong ram, ta dùng nhóm class thay cho mảng để fix cho những hạn chế của mảng
//  những class này đều chứa bên trong nó khi nó dc new bên trong vùng new này sẽ chứa nhiều biến nhỏ hơn biến khác -
//  y chang vùng new mảng sẽ chứa nhiều biến bên trong
//  khác mảng, vùng nhớ này có co giãn, chứa nhiều thì nở ra, chứa ít thì co lại, xóa thì mất luôn cái xóa, có giãn linh hoạt
// nồi cơm thạch sanh, anh em cây khế
// toàn bộ các nhóm class này gọi chung là COLLECTIONS
// chúng sẽ gồm nhiều interface, nhiều astract class        nhiều class cụ thể
//                   -------------------------------        ------------------    
//                    kh new dc, vì chứa hàm kh có code     new dc, concrete class
//JAVA:
// abtract class, interface: List           Set                 Map(kh có new)
// concrete class, new dc  : ArrayList    HashSet, TreeSet      HashMap, TreeMap
//                           vào thứ tự nào
//                           ra thứ tự nấy
// khai báo: List<Student> arr = new List<Student>() // vỡ mặt, vì sẽ sinh ra 20 hàm kh code, yêu cầu code tiếp/ implement -> ANNONYMOUS CLASS 1 câu chuyện khác -> cấm nghen!!

// khai cha new con okie
// List<Studnet> arr = new ArrayList<>();
// khai con new con, chuyện quá bth
// ArrayList<Student> = new ArrayList<Student>(); // bt mà 
// C#??? 
// ArrayList kh bà con gì với List
// ArrayList chứa cái gì bên trong cũng oke, và new dc, CONCRETE classs
// nhưng nó kh generic, thoải mái trong data nào cũng dc

// LIST CONCRETE CLASS luôn, tức là new dc ngay và luôn, và xài generic
// tức là chỉ add 1 loại data type - y chang cabinet<> nhà mình
// List<Student> List<Lecturer>

// nha sĩ khuyên dùng: list