using System;

namespace MtgDb.Info
{
    public interface IRepository
    {
        Guid AddPlaneswalker(string userName, string password, string email);
        void RemovePlaneswalker(Guid Id);
        Profile GetProfile(Guid Id);
        Planeswalker UpdatePlaneswalker(Planeswalker planeswalker);

        UserCard AddUserCard(Guid walkerId, int multiverseId, int amount);
        void UpdateUserCard(Guid id, int amount);
//        void UpdatePlaneswalker(Planeswalker planeswalker);
//
//        void SetCardAmount(Guid userId, int multiverseId, int amount);
    }
}

