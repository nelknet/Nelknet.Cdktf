namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVerifiedpermissionsPolicyStoreState<'Id> = { assignments: ResizeArray<aws.DataAwsVerifiedpermissionsPolicyStore.DataAwsVerifiedpermissionsPolicyStoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/verifiedpermissions_policy_store">aws_verifiedpermissions_policy_store</a>.
    /// </summary>
    type DataAwsVerifiedpermissionsPolicyStoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVerifiedpermissionsPolicyStoreState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVerifiedpermissionsPolicyStoreState<Missing>)

        member _.Zero(()) : DataAwsVerifiedpermissionsPolicyStoreState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVerifiedpermissionsPolicyStoreState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/verifiedpermissions_policy_store#id-1">DataAwsVerifiedpermissionsPolicyStore#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVerifiedpermissionsPolicyStoreState<Missing>, value: string) : DataAwsVerifiedpermissionsPolicyStoreState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsVerifiedpermissionsPolicyStoreState<Present>)

        member _.Run(state: DataAwsVerifiedpermissionsPolicyStoreState<Present>) : aws.DataAwsVerifiedpermissionsPolicyStore.DataAwsVerifiedpermissionsPolicyStore =
            let config = aws.DataAwsVerifiedpermissionsPolicyStore.DataAwsVerifiedpermissionsPolicyStoreConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVerifiedpermissionsPolicyStore.DataAwsVerifiedpermissionsPolicyStore(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVerifiedpermissionsPolicyStore: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVerifiedpermissionsPolicyStoreState<_>) : aws.DataAwsVerifiedpermissionsPolicyStore.DataAwsVerifiedpermissionsPolicyStore =
            Unchecked.defaultof<aws.DataAwsVerifiedpermissionsPolicyStore.DataAwsVerifiedpermissionsPolicyStore>
