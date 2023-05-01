using ASP.MusicMarket.Core.DTO_s;
using FluentValidation;

namespace ASP.MusicMarket.Api.Validators
{
    public class SaveArtistResourceValidator : AbstractValidator<SaveArtistDTO>
    {
        public SaveArtistResourceValidator()
        {
            RuleFor(a => a.Name).NotEmpty().MaximumLength(50);
        }
    }
}
