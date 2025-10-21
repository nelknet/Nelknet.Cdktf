namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain> = { assignments: ResizeArray<aws.AmplifyDomainAssociation.AmplifyDomainAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association">aws_amplify_domain_association</a>.
    /// </summary>
    type AmplifyDomainAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AmplifyDomainAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AmplifyDomainAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : AmplifyDomainAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AmplifyDomainAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#app_id-1">AmplifyDomainAssociation#app_id</a>.
        /// </summary>
        [<CustomOperation "app_id">]
        member _.AppId(state: AmplifyDomainAssociationState<Missing, 'DomainName, 'SubDomain>, value: string) : AmplifyDomainAssociationState<Present, 'DomainName, 'SubDomain> =
            state.assignments.Add(fun config -> config.AppId <- value)
            ({ assignments = state.assignments } : AmplifyDomainAssociationState<Present, 'DomainName, 'SubDomain>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#domain_name-1">AmplifyDomainAssociation#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: AmplifyDomainAssociationState<'AppId, Missing, 'SubDomain>, value: string) : AmplifyDomainAssociationState<'AppId, Present, 'SubDomain> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : AmplifyDomainAssociationState<'AppId, Present, 'SubDomain>)

        /// <summary>
        /// sub_domain block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#sub_domain-1">AmplifyDomainAssociation#sub_domain</a> Accepts: aws.IResolvable | aws.AmplifyDomainAssociation.AmplifyDomainAssociationSubDomain[]
        /// </summary>
        [<CustomOperation "sub_domain">]
        member _.SubDomain(state: AmplifyDomainAssociationState<'AppId, 'DomainName, Missing>, value: HashiCorp.Cdktf.IResolvable) : AmplifyDomainAssociationState<'AppId, 'DomainName, Present> =
            state.assignments.Add(fun config -> config.SubDomain <- value)
            ({ assignments = state.assignments } : AmplifyDomainAssociationState<'AppId, 'DomainName, Present>)

        /// <summary>
        /// certificate_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#certificate_settings-1">AmplifyDomainAssociation#certificate_settings</a>
        /// </summary>
        [<CustomOperation "certificate_settings">]
        member _.CertificateSettings(state: AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>, value: aws.AmplifyDomainAssociation.AmplifyDomainAssociationCertificateSettings) : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain> =
            state.assignments.Add(fun config -> config.CertificateSettings <- value)
            state : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#enable_auto_sub_domain-1">AmplifyDomainAssociation#enable_auto_sub_domain</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_auto_sub_domain">]
        member _.EnableAutoSubDomain(state: AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>, value: bool) : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain> =
            state.assignments.Add(fun config -> config.EnableAutoSubDomain <- value)
            state : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#enable_auto_sub_domain-1">AmplifyDomainAssociation#enable_auto_sub_domain</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_auto_sub_domain">]
        member _.EnableAutoSubDomain(state: AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>, value: HashiCorp.Cdktf.IResolvable) : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain> =
            state.assignments.Add(fun config -> config.EnableAutoSubDomain <- value)
            state : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#id-1">AmplifyDomainAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>, value: string) : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#wait_for_verification-1">AmplifyDomainAssociation#wait_for_verification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_verification">]
        member _.WaitForVerification(state: AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>, value: bool) : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain> =
            state.assignments.Add(fun config -> config.WaitForVerification <- value)
            state : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_domain_association#wait_for_verification-1">AmplifyDomainAssociation#wait_for_verification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_verification">]
        member _.WaitForVerification(state: AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>, value: HashiCorp.Cdktf.IResolvable) : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain> =
            state.assignments.Add(fun config -> config.WaitForVerification <- value)
            state : AmplifyDomainAssociationState<'AppId, 'DomainName, 'SubDomain>

        member _.Run(state: AmplifyDomainAssociationState<Present, Present, Present>) : aws.AmplifyDomainAssociation.AmplifyDomainAssociation =
            let config = aws.AmplifyDomainAssociation.AmplifyDomainAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.AmplifyDomainAssociation.AmplifyDomainAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.amplifyDomainAssociation: missing required arguments. Must call: app_id, domain_name, sub_domain.", 9999, IsError = true)>]
        member _.Run(_: AmplifyDomainAssociationState<_, _, _>) : aws.AmplifyDomainAssociation.AmplifyDomainAssociation =
            Unchecked.defaultof<aws.AmplifyDomainAssociation.AmplifyDomainAssociation>
