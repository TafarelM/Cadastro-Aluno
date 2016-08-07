CREATE PROCEDURE SP_Aluno_ConsultarPorID
	@IDAluno INT
AS
BEGIN
	SELECT 
		Nome, 
		Sobrenome,
		CPF,
		RG,
		RGExp,
		DataNascimento,
		Email,
		Sexo,
		Telefone,
		Celular,
		Usuario
	FROM 
		Aluno
	WHERE
		IDAluno = @IDAluno
END
---- teste -------
SELECT * FROM Aluno

EXEC SP_Aluno_ConsultarPorID 1