namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCanonicalUserIdState = { assignments: ResizeArray<aws.DataAwsCanonicalUserId.DataAwsCanonicalUserIdConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/canonical_user_id">aws_canonical_user_id</a>.
    /// </summary>
    type DataAwsCanonicalUserIdBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCanonicalUserIdState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCanonicalUserIdState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/canonical_user_id#id-1">DataAwsCanonicalUserId#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCanonicalUserIdState, value: string) : DataAwsCanonicalUserIdState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCanonicalUserIdState

        member _.Run(state: DataAwsCanonicalUserIdState) : aws.DataAwsCanonicalUserId.DataAwsCanonicalUserId =
            let config = aws.DataAwsCanonicalUserId.DataAwsCanonicalUserIdConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCanonicalUserId.DataAwsCanonicalUserId(StackContext.get (), logicalId, config)
