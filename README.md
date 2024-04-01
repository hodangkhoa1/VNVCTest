# App chạy trên .NET 8
# Link API: https://dienmaysaigonxanh.com:442/swagger/index.html
# Dùng app Visual Studio để chạy project
# Cách thực hiện để chạy project
  ## Bước 1: Cài đặt .NET 8 và SQL Server
    - https://dotnet.microsoft.com/en-us/download/dotnet/8.0
    - https://www.microsoft.com/en-us/sql-server/sql-server-downloads
  ## Bước 2: Chạy script SQL: VNVC_DB.sql (Bước này có thể bỏ qua vì API đã được deploy sẵn trên server)
  ## Bước 3: Cách chạy app đối với local (Bước này có thể bỏ qua vì API đã được deploy sẵn trên server)
    - Click chuột phải ở project VNVC_API chọn Set as Startup Project
    - Click chuột phải ở project VNVC_API hover vào Debug và chọn Start Without Debugging
    - Click chuột phải ở project VNVC_Client chọn Set as Startup Project
    - Click chuột phải ở project VNVC_Client hover vào Debug và chọn Start Without Debugging
  ## Bước 4: Cách chạy app đối với server
    - Click chuột phải ở project VNVC_Client chọn Set as Startup Project
    - Click chuột phải ở project VNVC_Client hover vào Debug và chọn Start Without Debugging
