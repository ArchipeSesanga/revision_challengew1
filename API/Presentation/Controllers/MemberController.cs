using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/member")]
public class MemberController : ControllerBase
{
    private readonly IMemberRepository _memberRepository;

    public MemberController(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }

    [HttpGet]
    [EndpointSummary("List all members")]
    [EndpointDescription("Returns every registered user.")]
 
    public ActionResult<IEnumerable<Member>> GetAll() =>
        Ok(_memberRepository.GetAll());

    

   
}