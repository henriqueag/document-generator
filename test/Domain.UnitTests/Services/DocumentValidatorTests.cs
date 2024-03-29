﻿namespace DocumentGeneratorApp.Domain.UnitTests.Services;

public class DocumentValidatorTests
{
    private readonly DocumentValidator _subject = new();

    [Fact]
    public void ValidateCpf_WhenCpfIsValid_ShouldBeTrue()
    {
        // Arrange
        const string cpf = "741.615.306-92";
        
        // Act
        var result = _subject.ValidateCpf(cpf);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void ValidateCpf_WhenCpfIsNotValid_ShouldBeFalse()
    {
        // Arrange
        const string cpf = "121.331.786-02";

        // Act
        var result = _subject.ValidateCpf(cpf);

        // Assert
        result.ShouldBeFalse();
    }

    [Theory]
    [InlineData("121.331.786-0")]
    [InlineData("121.331.786-004")]
    [InlineData("11111111111")]
    [InlineData("22222222222")]
    [InlineData("33333333333")]
    [InlineData("44444444444")]
    [InlineData("55555555555")]
    [InlineData("66666666666")]
    [InlineData("77777777777")]
    [InlineData("88888888888")]
    [InlineData("99999999999")]
    [InlineData("00000000000")]
    public void ValidateCpf_WhenCpfFormatIsNotValid_ShouldBeFalse(string cpf)
    {
        // Act
        var result = _subject.ValidateCpf(cpf);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void ValidateCnpj_WhenCpnjIsValid_ShouldBeTrue()
    {
        // Arrange
        const string cnpj = "48.627.888/0001-13";

        // Act
        var result = _subject.ValidateCnpj(cnpj);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void ValidateCnpj_WhenCnpjIsNotValid_ShouldBeFalse()
    {
        // Arrange
        const string cnpj = "48.627.888/0001-15";

        // Act
        var result = _subject.ValidateCnpj(cnpj);

        // Assert
        result.ShouldBeFalse();
    }

    [Theory]
    [InlineData("48.627.888/0001-1")]
    [InlineData("48.627.888/0001-154")]
    [InlineData("11111111111111")]
    [InlineData("22222222222222")]
    [InlineData("33333333333333")]
    [InlineData("44444444444444")]
    [InlineData("55555555555555")]
    [InlineData("66666666666666")]
    [InlineData("77777777777777")]
    [InlineData("88888888888888")]
    [InlineData("99999999999999")]
    [InlineData("00000000000000")]
    public void ValidateCnpj_WhenCnpjFormatIsNotValid_ShouldBeFalse(string cnpj)
    {
        // Act
        var result = _subject.ValidateCpf(cnpj);

        // Assert
        result.ShouldBeFalse();
    }

    [Fact]
    public void ValidateRg_WhenRgIsValid_ShouldBeTrue()
    {
        // Arrange
        const string rg = "43.999.928-5";

        // Act
        var result = _subject.ValidateRg(rg);

        // Assert
        result.ShouldBeTrue();
    }

    [Fact]
    public void ValidateRg_WhenRgIsNotValid_ShouldBeFalse()
    {
        // Arrange
        const string cpf = "43.999.928-3";

        // Act
        var result = _subject.ValidateRg(cpf);

        // Assert
        result.ShouldBeFalse();
    }

    [Theory]
    [InlineData("43.999.928-")]
    [InlineData("43.999.928-33")]
    [InlineData("439999283")]
    [InlineData("111111111")]
    [InlineData("222222222")]
    [InlineData("333333333")]
    [InlineData("444444444")]
    [InlineData("555555555")]
    [InlineData("666666666")]
    [InlineData("777777777")]
    [InlineData("888888888")]
    [InlineData("999999999")]
    [InlineData("000000000")]
    public void ValidateRg_WhenRgFormatIsNotValid_ShouldBeFalse(string rg)
    {
        // Act
        var result = _subject.ValidateCpf(rg);

        // Assert
        result.ShouldBeFalse();
    }
}