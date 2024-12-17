CREATE PROC proc_login
@username varchar(50),
@password varchar(50)
as
BEGIN
SELECT * FROM tbl_taikhoan WHERE sUserName =@username AND sPassWord = @password
END