CREATE PROCEDURE SP_Aluno_RecuperarSenha
	@Usuario VARCHAR(12),
	@DataNascimento DATE,
	@CPF VARCHAR(11)
AS
BEGIN
	SELECT 
		IDAluno
	FROM 
		Aluno 
	WHERE 
		Usuario = @Usuario AND DataNascimento = @DataNascimento AND CPF = @CPF
END