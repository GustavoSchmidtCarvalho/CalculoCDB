using System.ComponentModel.DataAnnotations;

namespace CalculoCDBApi.Data.VO
{
    public class InvestimentoVO : IValidatableObject
    {
        [Required]
        public double ValorInicial { get; set; }
        [Required]
        public int QtdMeses { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.ValorInicial <= 0)
                yield return new ValidationResult("O valor inicial do investimento deve ser maior que 0", new[] { nameof(ValorInicial) });
            if (this.QtdMeses <= 1)
                yield return new ValidationResult("Total de meses deve ser maior que 1", new[] { nameof(QtdMeses) });
        }
    }
}
