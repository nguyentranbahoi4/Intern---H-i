\## Lỗi 1 : Reference Type 

var sv1 = new Student { Name = "Dũng" };

DoiTen(sv1);

Console.WriteLine($"Sau DoiTen : {sv1.Name}");



var sv2 = new Student { Name = "Dũng" };

DoiNguoi(sv2);

Console.WriteLine($"Sau DoiNguoi : {sv2.Name}");



void DoiTen(Student s)

{

&#x20;   s.Name = "Cường";

}



void DoiNguoi(Student s)

{

&#x20;   s = new Student { Name = "Cường" };

}



class Student

{

&#x20;   public string Name { get; set; } = "";

}



* Ở sv1 : do trong DoiTen , biến s không tạo them đối tượng Student , cho nên s chép địa chỉ của sv1 và cả 2 đồng thời trỏ tới object Student cho nên khi s.Name đổi tên -> Cường , thì sv1 đang trỏ tới Student , cho nên sv1.Name = Cường
* Ở sv2 : do trong DoiNguoi ,  s chép địa chỉ của sv2 và cả 2 đồng thời trỏ tới object Student Name = Dũng , sau đó s tạo object Student , lúc này s trỏ tới object Student mới có Name = Cường , và sv2 vẫn giữ nguyên nên sv 2 = Dũng



\## Lần sau nhớ gì : 

\*\*Đoạn code gây nhầm:\*\*

```csharp

void DoiTen(Student s)   { s.Name = "Cường"; }          // sửa bên trong object

void DoiNguoi(Student s) { s = new Student { Name = "Cường" }; } // đổi biến s sang object khác

```



\*\*Vì sao sai:\*\*

\- Tham số `s` chỉ là \*\*bản sao của địa chỉ\*\* của `sv`.

\- `s.Name = ...`: đi theo địa chỉ, sửa object dùng chung, nên `sv` đổi theo.

\- `s = new ...`: `s` trỏ sang object mới, `sv` vẫn trỏ object cũ, nên `sv` không đổi.



\*\*Lần sau nhớ gì:\*\*

\- Có dấu chấm (`s.Name = ...`) thì ảnh hưởng bên ngoài.

\- Gán trực tiếp (`s = ...`) thì không ảnh hưởng bên ngoài.

