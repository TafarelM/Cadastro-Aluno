CREATE PROCEDURE SP_Aluno_Excluir
	@IDAluno INT
AS
BEGIN
	DELETE FROM Aluno
	WHERE
	IDAluno = @IDAluno

	SELECT @IDAluno as retorno
END
----------- TESTE ------------------
SELECT * FROM Aluno

EXEC SP_Aluno_Excluir 1