CREATE PROCEDURE SP_Aluno_Login
	@Usuario VARCHAR(12),
	@senha   VARCHAR(12)
AS
BEGIN
	SELECT 
		COUNT(IDAluno) 
	FROM 
		Aluno 
	WHERE 
		Usuario = @Usuario AND Senha = @Senha 
END

EXEC SP_Aluno_Login 'admin', '123'