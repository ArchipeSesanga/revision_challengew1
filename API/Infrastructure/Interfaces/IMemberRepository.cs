public interface IMemberRepository
{ IReadOnlyCollection<Member> GetAll();
    Member? GetById(Guid id);
    void Add(Member member);
    
}