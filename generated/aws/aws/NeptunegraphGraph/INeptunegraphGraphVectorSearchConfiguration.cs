using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NeptunegraphGraph
{
    [JsiiInterface(nativeType: typeof(INeptunegraphGraphVectorSearchConfiguration), fullyQualifiedName: "aws.neptunegraphGraph.NeptunegraphGraphVectorSearchConfiguration")]
    public interface INeptunegraphGraphVectorSearchConfiguration
    {
        /// <summary>Specifies the number of dimensions for vector embeddings.  Value must be between 1 and 65,535.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#vector_search_dimension NeptunegraphGraph#vector_search_dimension}
        /// </remarks>
        [JsiiProperty(name: "vectorSearchDimension", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VectorSearchDimension
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INeptunegraphGraphVectorSearchConfiguration), fullyQualifiedName: "aws.neptunegraphGraph.NeptunegraphGraphVectorSearchConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.NeptunegraphGraph.INeptunegraphGraphVectorSearchConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the number of dimensions for vector embeddings.  Value must be between 1 and 65,535.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#vector_search_dimension NeptunegraphGraph#vector_search_dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectorSearchDimension", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VectorSearchDimension
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
