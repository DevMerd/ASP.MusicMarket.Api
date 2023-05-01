using ASP.MusicMarket.Core.DTO_s;
using FluentValidation;

namespace ASP.MusicMarket.Api.Validators
{
    public class SaveMusicResourceValidator : AbstractValidator<SaveMusicDTO>
    {
        public SaveMusicResourceValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(m => m.ArtistId)
                .NotEmpty()
                .WithMessage("'Artist Id' must not be 0.");
        }
    }
}
