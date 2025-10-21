namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IdentitystoreGroupState<'DisplayName, 'IdentityStoreId> = { assignments: ResizeArray<aws.IdentitystoreGroup.IdentitystoreGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group">aws_identitystore_group</a>.
    /// </summary>
    type IdentitystoreGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : IdentitystoreGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IdentitystoreGroupState<Missing, Missing>)

        member _.Zero(()) : IdentitystoreGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IdentitystoreGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group#display_name-1">IdentitystoreGroup#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: IdentitystoreGroupState<Missing, 'IdentityStoreId>, value: string) : IdentitystoreGroupState<Present, 'IdentityStoreId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : IdentitystoreGroupState<Present, 'IdentityStoreId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group#identity_store_id-1">IdentitystoreGroup#identity_store_id</a>.
        /// </summary>
        [<CustomOperation "identity_store_id">]
        member _.IdentityStoreId(state: IdentitystoreGroupState<'DisplayName, Missing>, value: string) : IdentitystoreGroupState<'DisplayName, Present> =
            state.assignments.Add(fun config -> config.IdentityStoreId <- value)
            ({ assignments = state.assignments } : IdentitystoreGroupState<'DisplayName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group#description-1">IdentitystoreGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: IdentitystoreGroupState<'DisplayName, 'IdentityStoreId>, value: string) : IdentitystoreGroupState<'DisplayName, 'IdentityStoreId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : IdentitystoreGroupState<'DisplayName, 'IdentityStoreId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_group#id-1">IdentitystoreGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IdentitystoreGroupState<'DisplayName, 'IdentityStoreId>, value: string) : IdentitystoreGroupState<'DisplayName, 'IdentityStoreId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IdentitystoreGroupState<'DisplayName, 'IdentityStoreId>

        member _.Run(state: IdentitystoreGroupState<Present, Present>) : aws.IdentitystoreGroup.IdentitystoreGroup =
            let config = aws.IdentitystoreGroup.IdentitystoreGroupConfig()
            for setter in state.assignments do
                setter config
            aws.IdentitystoreGroup.IdentitystoreGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.identitystoreGroup: missing required arguments. Must call: display_name, identity_store_id.", 9999, IsError = true)>]
        member _.Run(_: IdentitystoreGroupState<_, _>) : aws.IdentitystoreGroup.IdentitystoreGroup =
            Unchecked.defaultof<aws.IdentitystoreGroup.IdentitystoreGroup>
