namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamSamlProviderState<'Arn> = { assignments: ResizeArray<aws.DataAwsIamSamlProvider.DataAwsIamSamlProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_saml_provider">aws_iam_saml_provider</a>.
    /// </summary>
    type DataAwsIamSamlProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamSamlProviderState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamSamlProviderState<Missing>)

        member _.Zero(()) : DataAwsIamSamlProviderState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamSamlProviderState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_saml_provider#arn-1">DataAwsIamSamlProvider#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsIamSamlProviderState<Missing>, value: string) : DataAwsIamSamlProviderState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsIamSamlProviderState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_saml_provider#id-1">DataAwsIamSamlProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamSamlProviderState<'Arn>, value: string) : DataAwsIamSamlProviderState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamSamlProviderState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_saml_provider#tags-1">DataAwsIamSamlProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsIamSamlProviderState<'Arn>, value: seq<string * string>) : DataAwsIamSamlProviderState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsIamSamlProviderState<'Arn>

        member _.Run(state: DataAwsIamSamlProviderState<Present>) : aws.DataAwsIamSamlProvider.DataAwsIamSamlProvider =
            let config = aws.DataAwsIamSamlProvider.DataAwsIamSamlProviderConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamSamlProvider.DataAwsIamSamlProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamSamlProvider: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamSamlProviderState<_>) : aws.DataAwsIamSamlProvider.DataAwsIamSamlProvider =
            Unchecked.defaultof<aws.DataAwsIamSamlProvider.DataAwsIamSamlProvider>
