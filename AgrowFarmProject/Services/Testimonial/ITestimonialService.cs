namespace AgrowFarmProject.Services.Testimonial
{
	public interface ITestimonialService
	{
		Task<List<Models.Testimonial>> GetAllTestimonial();
		Task<Models.Testimonial> GetByIdTestimonial(string id);
		Task CreateTestimonial(Models.Testimonial testimonial);
		Task UpdateTestimonial(Models.Testimonial testimonial);
		Task DeleteTestimonial(string id);
	}
}
