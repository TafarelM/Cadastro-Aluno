CREATE PROCEDURE SP_Aluno_Alterar
	@IDAluno INT,
	@Nome VARCHAR(50),
	@Sobrenome VARCHAR(50),
	@CPF VARCHAR(11),
	@RG VARCHAR(14),
	@RGExp VARCHAR(50),
	@DataNascimento DATE,
	@Email VARCHAR(50),
	@Sexo VARCHAR(12),
	@Telefone VARCHAR(15),
	@Celular VARCHAR(20),
	@Usuario VARCHAR(12),
	@Senha VARCHAR(12)
AS
BEGIN
	UPDATE Aluno
	SET 
		Nome = @Nome, 
		Sobrenome = @Sobrenome,
		CPF = @CPF,
		RG = @RG,
		RGExp = @RGExp,
		DataNascimento = @DataNascimento,
		Email = @Email,
		Sexo = @Sexo,
		Telefone = @Telefone,
		Celular = @Celular,
		Usuario = @Usuario,
		Senha = @Senha
	WHERE
		IDAluno = @IDAluno

	SELECT @IDAluno as retorno
END


------------ TESTE -------------

SELECT * FROM Aluno

EXEC SP_Aluno_Alterar 1, 'teste', 'sobren', '15975312312', '456321789', 'sp', '22-12-2000', 'teste@email.com', 'masculino', '214578963', '1592356984152', 'teste', '1234'