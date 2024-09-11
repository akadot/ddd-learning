using System;
using Domain;
using Domain.Enums;

namespace Application.Guests.DTO;

public class GuestDTO
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string IdNumber {get;set;} = null!;
    public int IdTypeCode {get;set;}

    public static Guest MapToEntity(GuestDTO dto){
        return new Guest{
            Name = dto.Name,
            Surname = dto.Surname,
            Email = dto.Email,
            DocumentId = new Domain.ValueObjects.PersonId
            {
                IdNumber = dto.IdNumber,
                DocumentType = (DocumentType)dto.IdTypeCode
            }
        };
    }
}
