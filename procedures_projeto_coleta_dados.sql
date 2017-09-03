select * from TBAlunos

CREATE PROCEDURE ListaAlunos
AS
BEGIN
	SELECT *	
		FROM TBAlunos
END

exec ListaAlunos

CREATE PROCEDURE InsereAlunos
	@RA varchar(13),
	@Nome varchar(120),
	@Email varchar(120),
	@Carimbo date,
	@Nascimento date,
	@Deficiencia varchar(3),
	@EstadoCivil varchar(11),
	@Filhos int,
	@Cidade varchar(6),
	@Locomocao varchar(10),
	@SituacaoDomiciliar varchar(10),
	@TempoMoradia int,
	@MoraCom varchar(10),
	@Trabalha varchar(50),
	@MediaRenda int,
	@PeriodoEstudo varchar(9),
	@PessoasResidem int,
	@PessoasTrabalham int,
	@SomaRendas int,
	@PeriodoTrabalho varchar(9),
	@VidaEscolar varchar(50),
	@ConhecimentoInformatica varchar(15),
	@MotivoVestibular varchar(50),
	@ConhecimentoLingua varchar(3),
	@Linguas varchar(20),
	@Meio varchar(3)
AS
BEGIN
	INSERT 
		INTO TBAlunos(RA,Nome,Email,Carimbo,Nascimento,Deficiencia,EstadoCivil,Filhos,Cidade,Locomocao,SituacaoDomiciliar,TempoMoradia,MoraCom,Trabalha,MediaRenda,PeriodoEstudo,PessoasResidem,PessoasTrabalham,SomaRendas,PeriodoTrabalho,VidaEscolar,ConhecimentoInformatica,MotivoVestibular,ConhecimentoLingua,Linguas,Meio)
			VALUES(@RA,@Nome,@Email,@Carimbo,@Nascimento,@Deficiencia,@EstadoCivil,@Filhos,@Cidade,@Locomocao,@SituacaoDomiciliar,@TempoMoradia,@MoraCom,@Trabalha,@MediaRenda,@PeriodoEstudo,@PessoasResidem,@PessoasTrabalham,@SomaRendas,@PeriodoTrabalho,@VidaEscolar,@ConhecimentoInformatica,@MotivoVestibular,@ConhecimentoLingua,@Linguas,@Meio)
END


