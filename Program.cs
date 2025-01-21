public abstract class A{
    public void Print(){
        Console.WriteLine(this.GetType().Name);
    }
    public abstract void Move();
}
public abstract class B:A{

}
public class C:A{
    override public void Move(){
        Console.WriteLine("Move");
    }
    public void Unique(){
        Console.WriteLine("Unique");
    }
}
public class X{
    public void Print(){
        Console.Write("Parent: ");
        //Console.WriteLine(this.GetType().Name);
    }
}
public class Y:X{
    public void Print(){
        Console.Write("Child: ");
        //Console.WriteLine(this.GetType().Name);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        /*C c = new C();
        c.Print();
        c.Move();

        A a = new C();
        //a.Unique(); -> Error
        ((C)a).Unique();*/
        X x = new X();
        Y y = new Y();
        x.Print();
        y.Print();
    }
}

/*** Lab 03 ***
Một lớp AVector có các phương thức:
- ShowInfo: hiển thị thông tin của lớp
- Add: cộng 2 AVector
- Sub: trừ 2 AVector
- Mul: nhân 2 AVector
- Div: chia 2 AVector
- Dot: tích vô hướng 2 AVector
- Module: độ dài của AVector
- Angle: góc giữa 2 AVector
Tất cả các phương thức ở trên đều đặc tả dưới dạng lớp trừu tượng abstract.

Khai báo 2 lớp Vector2D và Vector3D kế thừa từ AVector. Cài đặt các phương thức ở lớp cha.
Trong đó, lớp Vector2D chứa hai thuộc tính x và y (float); lớp Vector3D chứa ba thuộc tính x, y và z (float).
Bổ sung các phương thức cần thiết khác cho mỗi lớp như constructor, getter, setter nếu cần.

Trong hàm main, tạo ra một List các Vector hỗn hợp (Vector2D và Vector3D). 
Thực hiện các phép toán cơ bản giữa các phần tử trong List.
*/