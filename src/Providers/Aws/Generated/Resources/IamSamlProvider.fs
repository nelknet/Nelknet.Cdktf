namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamSamlProviderState<'Name, 'SamlMetadataDocument> = { assignments: ResizeArray<aws.IamSamlProvider.IamSamlProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_saml_provider">aws_iam_saml_provider</a>.
    /// </summary>
    type IamSamlProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamSamlProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamSamlProviderState<Missing, Missing>)

        member _.Zero(()) : IamSamlProviderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamSamlProviderState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_saml_provider#name-1">IamSamlProvider#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamSamlProviderState<Missing, 'SamlMetadataDocument>, value: string) : IamSamlProviderState<Present, 'SamlMetadataDocument> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IamSamlProviderState<Present, 'SamlMetadataDocument>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_saml_provider#saml_metadata_document-1">IamSamlProvider#saml_metadata_document</a>.
        /// </summary>
        [<CustomOperation "saml_metadata_document">]
        member _.SamlMetadataDocument(state: IamSamlProviderState<'Name, Missing>, value: string) : IamSamlProviderState<'Name, Present> =
            state.assignments.Add(fun config -> config.SamlMetadataDocument <- value)
            ({ assignments = state.assignments } : IamSamlProviderState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_saml_provider#id-1">IamSamlProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamSamlProviderState<'Name, 'SamlMetadataDocument>, value: string) : IamSamlProviderState<'Name, 'SamlMetadataDocument> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamSamlProviderState<'Name, 'SamlMetadataDocument>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_saml_provider#tags-1">IamSamlProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamSamlProviderState<'Name, 'SamlMetadataDocument>, value: seq<string * string>) : IamSamlProviderState<'Name, 'SamlMetadataDocument> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamSamlProviderState<'Name, 'SamlMetadataDocument>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_saml_provider#tags_all-1">IamSamlProvider#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamSamlProviderState<'Name, 'SamlMetadataDocument>, value: seq<string * string>) : IamSamlProviderState<'Name, 'SamlMetadataDocument> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamSamlProviderState<'Name, 'SamlMetadataDocument>

        member _.Run(state: IamSamlProviderState<Present, Present>) : aws.IamSamlProvider.IamSamlProvider =
            let config = aws.IamSamlProvider.IamSamlProviderConfig()
            for setter in state.assignments do
                setter config
            aws.IamSamlProvider.IamSamlProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamSamlProvider: missing required arguments. Must call: name, saml_metadata_document.", 9999, IsError = true)>]
        member _.Run(_: IamSamlProviderState<_, _>) : aws.IamSamlProvider.IamSamlProvider =
            Unchecked.defaultof<aws.IamSamlProvider.IamSamlProvider>
