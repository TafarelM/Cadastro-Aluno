CREATE PROCEDURE SP_Aluno_TrocarSenha
	@IDAluno INT,
	@senha VARCHAR(12)
AS
BEGIN
	UPDATE Aluno
	SET 
		Senha = @senha

	WHERE
		IDAluno = @idAluno

	SELECT @IDAluno as retorno
END