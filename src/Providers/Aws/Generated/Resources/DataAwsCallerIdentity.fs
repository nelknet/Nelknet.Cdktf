namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCallerIdentityState = { assignments: ResizeArray<aws.DataAwsCallerIdentity.DataAwsCallerIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/caller_identity">aws_caller_identity</a>.
    /// </summary>
    type DataAwsCallerIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCallerIdentityState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCallerIdentityState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/caller_identity#id-1">DataAwsCallerIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCallerIdentityState, value: string) : DataAwsCallerIdentityState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCallerIdentityState

        member _.Run(state: DataAwsCallerIdentityState) : aws.DataAwsCallerIdentity.DataAwsCallerIdentity =
            let config = aws.DataAwsCallerIdentity.DataAwsCallerIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCallerIdentity.DataAwsCallerIdentity(StackContext.get (), logicalId, config)
