using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NeptunegraphGraph
{
    [JsiiByValue(fqn: "aws.neptunegraphGraph.NeptunegraphGraphVectorSearchConfiguration")]
    public class NeptunegraphGraphVectorSearchConfiguration : aws.NeptunegraphGraph.INeptunegraphGraphVectorSearchConfiguration
    {
        /// <summary>Specifies the number of dimensions for vector embeddings.  Value must be between 1 and 65,535.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#vector_search_dimension NeptunegraphGraph#vector_search_dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vectorSearchDimension", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VectorSearchDimension
        {
            get;
            set;
        }
    }
}
