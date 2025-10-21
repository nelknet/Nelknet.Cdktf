namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferAccessState<'ExternalId, 'ServerId> = { assignments: ResizeArray<aws.TransferAccess.TransferAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access">aws_transfer_access</a>.
    /// </summary>
    type TransferAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferAccessState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferAccessState<Missing, Missing>)

        member _.Zero(()) : TransferAccessState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferAccessState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#external_id-1">TransferAccess#external_id</a>.
        /// </summary>
        [<CustomOperation "external_id">]
        member _.ExternalId(state: TransferAccessState<Missing, 'ServerId>, value: string) : TransferAccessState<Present, 'ServerId> =
            state.assignments.Add(fun config -> config.ExternalId <- value)
            ({ assignments = state.assignments } : TransferAccessState<Present, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#server_id-1">TransferAccess#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: TransferAccessState<'ExternalId, Missing>, value: string) : TransferAccessState<'ExternalId, Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : TransferAccessState<'ExternalId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#home_directory-1">TransferAccess#home_directory</a>.
        /// </summary>
        [<CustomOperation "home_directory">]
        member _.HomeDirectory(state: TransferAccessState<'ExternalId, 'ServerId>, value: string) : TransferAccessState<'ExternalId, 'ServerId> =
            state.assignments.Add(fun config -> config.HomeDirectory <- value)
            state : TransferAccessState<'ExternalId, 'ServerId>

        /// <summary>
        /// home_directory_mappings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#home_directory_mappings-1">TransferAccess#home_directory_mappings</a> Accepts: aws.IResolvable | aws.TransferAccess.TransferAccessHomeDirectoryMappings[]
        /// </summary>
        [<CustomOperation "home_directory_mappings">]
        member _.HomeDirectoryMappings(state: TransferAccessState<'ExternalId, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : TransferAccessState<'ExternalId, 'ServerId> =
            state.assignments.Add(fun config -> config.HomeDirectoryMappings <- value)
            state : TransferAccessState<'ExternalId, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#home_directory_type-1">TransferAccess#home_directory_type</a>.
        /// </summary>
        [<CustomOperation "home_directory_type">]
        member _.HomeDirectoryType(state: TransferAccessState<'ExternalId, 'ServerId>, value: string) : TransferAccessState<'ExternalId, 'ServerId> =
            state.assignments.Add(fun config -> config.HomeDirectoryType <- value)
            state : TransferAccessState<'ExternalId, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#id-1">TransferAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferAccessState<'ExternalId, 'ServerId>, value: string) : TransferAccessState<'ExternalId, 'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferAccessState<'ExternalId, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#policy-1">TransferAccess#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: TransferAccessState<'ExternalId, 'ServerId>, value: string) : TransferAccessState<'ExternalId, 'ServerId> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : TransferAccessState<'ExternalId, 'ServerId>

        /// <summary>
        /// posix_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#posix_profile-1">TransferAccess#posix_profile</a>
        /// </summary>
        [<CustomOperation "posix_profile">]
        member _.PosixProfile(state: TransferAccessState<'ExternalId, 'ServerId>, value: aws.TransferAccess.TransferAccessPosixProfile) : TransferAccessState<'ExternalId, 'ServerId> =
            state.assignments.Add(fun config -> config.PosixProfile <- value)
            state : TransferAccessState<'ExternalId, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_access#role-1">TransferAccess#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: TransferAccessState<'ExternalId, 'ServerId>, value: string) : TransferAccessState<'ExternalId, 'ServerId> =
            state.assignments.Add(fun config -> config.Role <- value)
            state : TransferAccessState<'ExternalId, 'ServerId>

        member _.Run(state: TransferAccessState<Present, Present>) : aws.TransferAccess.TransferAccess =
            let config = aws.TransferAccess.TransferAccessConfig()
            for setter in state.assignments do
                setter config
            aws.TransferAccess.TransferAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferAccess: missing required arguments. Must call: external_id, server_id.", 9999, IsError = true)>]
        member _.Run(_: TransferAccessState<_, _>) : aws.TransferAccess.TransferAccess =
            Unchecked.defaultof<aws.TransferAccess.TransferAccess>
