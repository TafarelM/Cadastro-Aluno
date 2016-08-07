CREATE PROCEDURE SP_Aluno_ConsultarPorNome
	@Nome VARCHAR(100)
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
		Nome LIKE '%' + @Nome + '%' OR Sobrenome LIKE '%' + @Nome + '%'
END
---- teste -------
SELECT * FROM Aluno

EXEC SP_Aluno_ConsultarPorNome ''