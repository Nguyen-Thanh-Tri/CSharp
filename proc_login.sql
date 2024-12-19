ALTER PROC proc_login
@username varchar(50),
@password varchar(50)
as
BEGIN
	SELECT  t.sUserName,
			t.sPassWord,
			r.sRoleName
	FROM tbl_taikhoan t
	JOIN tbl_Role r ON t.FK_iRole=r.iRole
	WHERE t.sUserName =@username AND t.sPassWord = @password
END