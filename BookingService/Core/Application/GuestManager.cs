using Application.Guests.DTO;
using Application.Guests.Ports;
using Application.Guests.Requests;
using Application.Guests.Responses;
using Domain;

namespace Application;

public class GuestManager : IGuestManager
{
    private IGuestRepository _guestRepository;
    public GuestManager(IGuestRepository repository)
    {
        _guestRepository = repository;
    }

    public async Task<GuestResponse> CreateGuest(CreateGuestRequest request)
    {
        try
        {
            Guest guest = GuestDTO.MapToEntity(request.Data);

            request.Data.Id = await _guestRepository.Create(guest);

            return new GuestResponse
            {
                Data = request.Data,
                Success = true
            };
        }
        catch (Exception ex)
        {
           return new GuestResponse
            {
                Success = false,
                ErrorCode = ErrorCodes.COULD_NOT_STORE_DATA,
                Message = ex.Message
            };
        }
    }
}
