using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationChat.Data;
using WebApplicationChat.Services;

namespace WebApplicationChat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactService _service;

        public ContactsController(ContactService service)
        {
            _service = service;
        }
        public class newContact
        {
            public string? contactid { get; set; }
            public string? username { get; set; }
            public string? name { get; set; }
            public string? server { get; set; }
        }

        public class editedContact
        {
            public string? username { get; set; }
            public string? name { get; set; }
            public string? server { get; set; }
        }


        // get all contacts of current user
        // GET: api/Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts(string username)
        {
            try
            {
                var result = await _service.GetContacts(username);
                return Ok(result);
            }
            catch
            {
                return BadRequest(); //to check what to return
            }
        }

        // get detailes of contact with a specific id
        // GET: api/Contacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(string id, string username)
        {
            var contact = await _service.GetContact(id, username);
            if (contact == null)
            {
                return NotFound();
            }
            return contact;
        }

        // edit a contact of the current user acorrding to a specific contact id
        // PUT: api/Contacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(string id, [FromBody] editedContact editedContact)
        {
            var contact = GetContact(id, editedContact.username);
            if (contact == null)
            {
                return NotFound();
            }
            await _service.SetContact(id, editedContact.username, editedContact.name, editedContact.server);
            return StatusCode(204);
        }

        // add a new contact to the contacts of the current user
        // POST: api/Contacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostContact([FromBody] newContact newContact)
        {

            if (newContact.contactid == newContact.username)
            {
                return BadRequest();
            }
            var contact = await _service.AddContact(newContact.contactid, newContact.username, newContact.name, newContact.server);
            if (contact != null)
            {
                return StatusCode(201);
            }
            return NotFound();
        }

        // delete a contact of the current user acorrding to a specific contact id
        // DELETE: api/Contacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(string id, [FromBody] string username)
        {
            var contact = GetContact(id, username);
            if (contact == null)
            {
                return NotFound();
            }
            await _service.DeleteContact(id, username);
            return StatusCode(204);
        }
    }
}
