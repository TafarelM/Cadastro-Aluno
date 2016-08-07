CREATE PROCEDURE SP_Aluno_Inserir
 --parametros
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
	INSERT INTO Aluno
	(
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
		Usuario,
		Senha
	)
	VALUES 
	(
		@Nome,
		@Sobrenome,
		@CPf,
		@RG,
		@RGExp,
		@DataNascimento,
		@Email,
		@Sexo,
		@Telefone,
		@Celular,
		@Usuario,
		@Senha
	)

	--retorna para o programa a id q foi inserida
	SELECT @@IDENTITY as retorno
END


----- TESTE ------
EXEC SP_Aluno_Inserir 'teste', 'sobren', '15975312312', '456321789', 'sp', '22-12-2000', 'teste@email.com', 'masculino', '214578963', '1592356984152', 'teste', '123'