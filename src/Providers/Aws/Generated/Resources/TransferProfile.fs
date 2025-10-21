namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferProfileState<'As2Id, 'ProfileType> = { assignments: ResizeArray<aws.TransferProfile.TransferProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_profile">aws_transfer_profile</a>.
    /// </summary>
    type TransferProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferProfileState<Missing, Missing>)

        member _.Zero(()) : TransferProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_profile#as2_id-1">TransferProfile#as2_id</a>.
        /// </summary>
        [<CustomOperation "as2_id">]
        member _.As2Id(state: TransferProfileState<Missing, 'ProfileType>, value: string) : TransferProfileState<Present, 'ProfileType> =
            state.assignments.Add(fun config -> config.As2Id <- value)
            ({ assignments = state.assignments } : TransferProfileState<Present, 'ProfileType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_profile#profile_type-1">TransferProfile#profile_type</a>.
        /// </summary>
        [<CustomOperation "profile_type">]
        member _.ProfileType(state: TransferProfileState<'As2Id, Missing>, value: string) : TransferProfileState<'As2Id, Present> =
            state.assignments.Add(fun config -> config.ProfileType <- value)
            ({ assignments = state.assignments } : TransferProfileState<'As2Id, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_profile#certificate_ids-1">TransferProfile#certificate_ids</a>.
        /// </summary>
        [<CustomOperation "certificate_ids">]
        member _.CertificateIds(state: TransferProfileState<'As2Id, 'ProfileType>, value: seq<string>) : TransferProfileState<'As2Id, 'ProfileType> =
            state.assignments.Add(fun config -> config.CertificateIds <- (value |> Seq.toArray))
            state : TransferProfileState<'As2Id, 'ProfileType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_profile#id-1">TransferProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferProfileState<'As2Id, 'ProfileType>, value: string) : TransferProfileState<'As2Id, 'ProfileType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferProfileState<'As2Id, 'ProfileType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_profile#tags-1">TransferProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TransferProfileState<'As2Id, 'ProfileType>, value: seq<string * string>) : TransferProfileState<'As2Id, 'ProfileType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TransferProfileState<'As2Id, 'ProfileType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_profile#tags_all-1">TransferProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TransferProfileState<'As2Id, 'ProfileType>, value: seq<string * string>) : TransferProfileState<'As2Id, 'ProfileType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TransferProfileState<'As2Id, 'ProfileType>

        member _.Run(state: TransferProfileState<Present, Present>) : aws.TransferProfile.TransferProfile =
            let config = aws.TransferProfile.TransferProfileConfig()
            for setter in state.assignments do
                setter config
            aws.TransferProfile.TransferProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferProfile: missing required arguments. Must call: as2_id, profile_type.", 9999, IsError = true)>]
        member _.Run(_: TransferProfileState<_, _>) : aws.TransferProfile.TransferProfile =
            Unchecked.defaultof<aws.TransferProfile.TransferProfile>
