namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration> = { assignments: ResizeArray<aws.ChimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain">aws_chimesdkvoice_voice_profile_domain</a>.
    /// </summary>
    type ChimesdkvoiceVoiceProfileDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : ChimesdkvoiceVoiceProfileDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimesdkvoiceVoiceProfileDomainState<Missing, Missing>)

        member _.Zero(()) : ChimesdkvoiceVoiceProfileDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ChimesdkvoiceVoiceProfileDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#name-1">ChimesdkvoiceVoiceProfileDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ChimesdkvoiceVoiceProfileDomainState<Missing, 'ServerSideEncryptionConfiguration>, value: string) : ChimesdkvoiceVoiceProfileDomainState<Present, 'ServerSideEncryptionConfiguration> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceVoiceProfileDomainState<Present, 'ServerSideEncryptionConfiguration>)

        /// <summary>
        /// server_side_encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#server_side_encryption_configuration-1">ChimesdkvoiceVoiceProfileDomain#server_side_encryption_configuration</a>
        /// </summary>
        [<CustomOperation "server_side_encryption_configuration">]
        member _.ServerSideEncryptionConfiguration(state: ChimesdkvoiceVoiceProfileDomainState<'Name, Missing>, value: aws.ChimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomainServerSideEncryptionConfiguration) : ChimesdkvoiceVoiceProfileDomainState<'Name, Present> =
            state.assignments.Add(fun config -> config.ServerSideEncryptionConfiguration <- value)
            ({ assignments = state.assignments } : ChimesdkvoiceVoiceProfileDomainState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#description-1">ChimesdkvoiceVoiceProfileDomain#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration>, value: string) : ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#tags-1">ChimesdkvoiceVoiceProfileDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration>, value: seq<string * string>) : ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#tags_all-1">ChimesdkvoiceVoiceProfileDomain#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration>, value: seq<string * string>) : ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_voice_profile_domain#timeouts-1">ChimesdkvoiceVoiceProfileDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration>, value: aws.ChimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomainTimeouts) : ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ChimesdkvoiceVoiceProfileDomainState<'Name, 'ServerSideEncryptionConfiguration>

        member _.Run(state: ChimesdkvoiceVoiceProfileDomainState<Present, Present>) : aws.ChimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomain =
            let config = aws.ChimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomainConfig()
            for setter in state.assignments do
                setter config
            aws.ChimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.chimesdkvoiceVoiceProfileDomain: missing required arguments. Must call: name, server_side_encryption_configuration.", 9999, IsError = true)>]
        member _.Run(_: ChimesdkvoiceVoiceProfileDomainState<_, _>) : aws.ChimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomain =
            Unchecked.defaultof<aws.ChimesdkvoiceVoiceProfileDomain.ChimesdkvoiceVoiceProfileDomain>
