using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ApiDemoPDF.Models
{
    public class Document
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Area { get; set; }
        public int? IdFile { get; set; }
        public DateTime? Publication { get; set; }
        public string? Version { get; set; }
        public string? Tags { get; set; }
        public DateTime? LastUpdated { get; set; }
        public List<string>? KeyWords { get; set; }
        public string? PathFile { get; set; }
        public FileInfo? File { get; set; }
    }


public static class DocumentEndpoints
{
	public static void MapDocumentEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Document").WithTags(nameof(Document));

        group.MapGet("/", () =>
        {
            return new [] { new Document() };
        })
        .WithName("GetAllDocuments")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new Document { ID = id };
        })
        .WithName("GetDocumentById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Document input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateDocument")
        .WithOpenApi();

        group.MapPost("/", (Document model) =>
        {
            //return TypedResults.Created($"/api/Documents/{model.ID}", model);
        })
        .WithName("CreateDocument")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new Document { ID = id });
        })
        .WithName("DeleteDocument")
        .WithOpenApi();
    }
}}
