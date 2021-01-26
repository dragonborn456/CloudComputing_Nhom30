# Cách cài đặt demo
Thực nghiệm chạy trang web compile code online bằng ngôn ngữ C# và Java

## Tiến hành cài đặt

### Tải và cài đặt Docker Desktop
 
Tải Docker Desktop: https://www.docker.com/

Cách cài đặt Docker: https://www.shaileshjha.com/step-by-step-how-to-install-docker-in-windows/#:~:text=Step%20by%20Step%20%E2%80%93%20How%20to%20Install%20Docker,6%20Check%20the%20version%20of%20Docker%20Installed.

### Tải và cài đặt Microsoft Visual Studio 2019
Tải Microsoft Visual Studio 2019: https://visualstudio.microsoft.com/downloads/

Cách cài đặt: https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019#:~:text=If%20you%20have%20Visual%20Studio,Then%2C%20choose%20Modify.



## Tải source code 

Tải source code .zip về máy.

Các thư mục bao gồm JavaCSharpCompiler và demo, file codetest.txt. Thư mục demo sẽ chứa Dockerfile và file .html



### Thư mục demo
Đưa file demo vào 1 đường dẫn bất kỳ trong máy tính.
Ví dụ: Cho thư mục demo sẽ nằm trong thư mục Admin
Địa chỉ đường dẫn = C:/Users/Admin/demo
    
### Thư mục JavaCSharpCompiler

Chạy file .sln trong thư mục để chạy project Windows Form

Mở Form1.cs( Double Click vào giao diện của Windows Form)

Tìm đến các dòng code sau:

```C#
string commmand = "docker build -t onlinecompiler C:/Users/Admin/demo";
            ExecuteCommandSync(commmand);
            string commmand1 = "docker run -p 4000:80 --name phong onlinecompiler";
            ExecuteCommandSync(commmand1);
            btnCmd.BackColor = Color.Blue;
```

Tiến hành thay đổi những dòng sau trong đoạn code trên:
+ onlinecompiler: Tên Image. Có thể thay đổi thành tên tùy thích.
+ C:/Users/Admin/demo: thay đổi thành địa chỉ đường dẫn của thư mục demo ở phần "Thư mục demo"
+ phong: tên Container. Có thể thay đổi thành tên tùy thích.

##  Chạy project WinForm
Chạy project WinForm và click button Tạo Image và Container

## Mở Docker Desktop
Mở Docker Desktop và kiểm tra xem Image và Container đã được tạo hay chưa?

Chạy Container. Vào trang web nhập localhost:4000 để mở ra trang web.

## Thử nghiệm code
Mở file codetest.txt để sử dụng 1 vài code mẫu về Java và C#

## Tắt demo
Đóng trang web.

Stop Container đang chạy.

Stop Project Winform.

