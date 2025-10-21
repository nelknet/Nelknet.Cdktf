namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamSessionContextState<'Arn> = { assignments: ResizeArray<aws.DataAwsIamSessionContext.DataAwsIamSessionContextConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_session_context">aws_iam_session_context</a>.
    /// </summary>
    type DataAwsIamSessionContextBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamSessionContextState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamSessionContextState<Missing>)

        member _.Zero(()) : DataAwsIamSessionContextState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamSessionContextState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_session_context#arn-1">DataAwsIamSessionContext#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsIamSessionContextState<Missing>, value: string) : DataAwsIamSessionContextState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsIamSessionContextState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_session_context#id-1">DataAwsIamSessionContext#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamSessionContextState<'Arn>, value: string) : DataAwsIamSessionContextState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamSessionContextState<'Arn>

        member _.Run(state: DataAwsIamSessionContextState<Present>) : aws.DataAwsIamSessionContext.DataAwsIamSessionContext =
            let config = aws.DataAwsIamSessionContext.DataAwsIamSessionContextConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamSessionContext.DataAwsIamSessionContext(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamSessionContext: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamSessionContextState<_>) : aws.DataAwsIamSessionContext.DataAwsIamSessionContext =
            Unchecked.defaultof<aws.DataAwsIamSessionContext.DataAwsIamSessionContext>
