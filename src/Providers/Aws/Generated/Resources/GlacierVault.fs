namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlacierVaultState<'Name> = { assignments: ResizeArray<aws.GlacierVault.GlacierVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault">aws_glacier_vault</a>.
    /// </summary>
    type GlacierVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlacierVaultState<Missing> =
            ({ assignments = ResizeArray() } : GlacierVaultState<Missing>)

        member _.Zero(()) : GlacierVaultState<Missing> =
            ({ assignments = ResizeArray() } : GlacierVaultState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#name-1">GlacierVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlacierVaultState<Missing>, value: string) : GlacierVaultState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlacierVaultState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#access_policy-1">GlacierVault#access_policy</a>.
        /// </summary>
        [<CustomOperation "access_policy">]
        member _.AccessPolicy(state: GlacierVaultState<'Name>, value: string) : GlacierVaultState<'Name> =
            state.assignments.Add(fun config -> config.AccessPolicy <- value)
            state : GlacierVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#id-1">GlacierVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlacierVaultState<'Name>, value: string) : GlacierVaultState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlacierVaultState<'Name>

        /// <summary>
        /// notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#notification-1">GlacierVault#notification</a>
        /// </summary>
        [<CustomOperation "notification">]
        member _.Notification(state: GlacierVaultState<'Name>, value: aws.GlacierVault.GlacierVaultNotification) : GlacierVaultState<'Name> =
            state.assignments.Add(fun config -> config.Notification <- value)
            state : GlacierVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#tags-1">GlacierVault#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlacierVaultState<'Name>, value: seq<string * string>) : GlacierVaultState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlacierVaultState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glacier_vault#tags_all-1">GlacierVault#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlacierVaultState<'Name>, value: seq<string * string>) : GlacierVaultState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlacierVaultState<'Name>

        member _.Run(state: GlacierVaultState<Present>) : aws.GlacierVault.GlacierVault =
            let config = aws.GlacierVault.GlacierVaultConfig()
            for setter in state.assignments do
                setter config
            aws.GlacierVault.GlacierVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glacierVault: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GlacierVaultState<_>) : aws.GlacierVault.GlacierVault =
            Unchecked.defaultof<aws.GlacierVault.GlacierVault>
