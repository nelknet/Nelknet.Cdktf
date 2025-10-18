namespace Nelknet.Cdktf.Providers.Hcloud

open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf.FSharp

module Hcloud =
    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate hcloud_certificate}.
    type CertificateBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#certificate Certificate#certificate}.
        [<CustomOperation "certificate">]
        member _.Certificate((), value: string) =
            assignments.Add("Certificate", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#name Certificate#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#private_key Certificate#private_key}.
        [<CustomOperation "private_key">]
        member _.PrivateKey((), value: string) =
            assignments.Add("PrivateKey", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#id Certificate#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/certificate#labels Certificate#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        member _.Run(_: unit) =
            let config = hcloud.Certificate.CertificateConfig()
            BuilderInternals.apply assignments config
            hcloud.Certificate.Certificate_(StackContext.get (), logicalId, config)

    let certificate logicalId = CertificateBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificate hcloud_certificate}.
    type DataHcloudCertificateBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificate#id DataHcloudCertificate#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificate#name DataHcloudCertificate#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificate#with_selector DataHcloudCertificate#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudCertificate.DataHcloudCertificateConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudCertificate.DataHcloudCertificate(StackContext.get (), logicalId, config)

    let dataHcloudCertificate logicalId = DataHcloudCertificateBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificates hcloud_certificates}.
    type DataHcloudCertificatesBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificates#id DataHcloudCertificates#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/certificates#with_selector DataHcloudCertificates#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudCertificates.DataHcloudCertificatesConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudCertificates.DataHcloudCertificates(StackContext.get (), logicalId, config)

    let dataHcloudCertificates logicalId =
        DataHcloudCertificatesBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/datacenter hcloud_datacenter}.
    type DataHcloudDatacenterBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// ID of the Datacenter.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/datacenter#id DataHcloudDatacenter#id}
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Name of the Datacenter.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/datacenter#name DataHcloudDatacenter#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudDatacenter.DataHcloudDatacenterConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudDatacenter.DataHcloudDatacenter(StackContext.get (), logicalId, config)

    let dataHcloudDatacenter logicalId = DataHcloudDatacenterBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/datacenters hcloud_datacenters}.
    type DataHcloudDatacentersBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudDatacenters.DataHcloudDatacentersConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudDatacenters.DataHcloudDatacenters(StackContext.get (), logicalId, config)

    let dataHcloudDatacenters logicalId = DataHcloudDatacentersBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall hcloud_firewall}.
    type DataHcloudFirewallBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// apply_to block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#apply_to DataHcloudFirewall#apply_to}
        /// Accepts: hcloud.IResolvable | hcloud.DataHcloudFirewall.DataHcloudFirewallApplyTo[]
        [<CustomOperation "apply_to">]
        member _.ApplyTo((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("ApplyTo", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#id DataHcloudFirewall#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#labels DataHcloudFirewall#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#most_recent DataHcloudFirewall#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: bool) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#most_recent DataHcloudFirewall#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#name DataHcloudFirewall#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// rule block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#rule DataHcloudFirewall#rule}
        /// Accepts: hcloud.IResolvable | hcloud.DataHcloudFirewall.DataHcloudFirewallRule[]
        [<CustomOperation "rule">]
        member _.Rule((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Rule", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewall#with_selector DataHcloudFirewall#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudFirewall.DataHcloudFirewallConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudFirewall.DataHcloudFirewall(StackContext.get (), logicalId, config)

    let dataHcloudFirewall logicalId = DataHcloudFirewallBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls hcloud_firewalls}.
    type DataHcloudFirewallsBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls#id DataHcloudFirewalls#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls#most_recent DataHcloudFirewalls#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: bool) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls#most_recent DataHcloudFirewalls#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/firewalls#with_selector DataHcloudFirewalls#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudFirewalls.DataHcloudFirewallsConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudFirewalls.DataHcloudFirewalls(StackContext.get (), logicalId, config)

    let dataHcloudFirewalls logicalId = DataHcloudFirewallsBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip hcloud_floating_ip}.
    type DataHcloudFloatingIpBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#id DataHcloudFloatingIp#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#ip_address DataHcloudFloatingIp#ip_address}.
        [<CustomOperation "ip_address">]
        member _.IpAddress((), value: string) = assignments.Add("IpAddress", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#name DataHcloudFloatingIp#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#selector DataHcloudFloatingIp#selector}.
        [<CustomOperation "selector">]
        member _.Selector((), value: string) = assignments.Add("Selector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ip#with_selector DataHcloudFloatingIp#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudFloatingIp.DataHcloudFloatingIpConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudFloatingIp.DataHcloudFloatingIp(StackContext.get (), logicalId, config)

    let dataHcloudFloatingIp logicalId = DataHcloudFloatingIpBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ips hcloud_floating_ips}.
    type DataHcloudFloatingIpsBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ips#id DataHcloudFloatingIps#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/floating_ips#with_selector DataHcloudFloatingIps#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudFloatingIps.DataHcloudFloatingIpsConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudFloatingIps.DataHcloudFloatingIps(StackContext.get (), logicalId, config)

    let dataHcloudFloatingIps logicalId = DataHcloudFloatingIpsBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image hcloud_image}.
    type DataHcloudImageBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#id DataHcloudImage#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#include_deprecated DataHcloudImage#include_deprecated}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated((), value: bool) =
            assignments.Add("IncludeDeprecated", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#include_deprecated DataHcloudImage#include_deprecated}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("IncludeDeprecated", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#most_recent DataHcloudImage#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: bool) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#most_recent DataHcloudImage#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#name DataHcloudImage#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#selector DataHcloudImage#selector}.
        [<CustomOperation "selector">]
        member _.Selector((), value: string) = assignments.Add("Selector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#with_architecture DataHcloudImage#with_architecture}.
        [<CustomOperation "with_architecture">]
        member _.WithArchitecture((), value: string) =
            assignments.Add("WithArchitecture", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#with_selector DataHcloudImage#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#with_status DataHcloudImage#with_status}.
        [<CustomOperation "with_status">]
        member _.WithStatus((), value: seq<string>) =
            assignments.Add("WithStatus", box (value |> Seq.toArray))

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudImage.DataHcloudImageConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudImage.DataHcloudImage(StackContext.get (), logicalId, config)

    let dataHcloudImage logicalId = DataHcloudImageBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images hcloud_images}.
    type DataHcloudImagesBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#id DataHcloudImages#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#include_deprecated DataHcloudImages#include_deprecated}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated((), value: bool) =
            assignments.Add("IncludeDeprecated", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#include_deprecated DataHcloudImages#include_deprecated}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("IncludeDeprecated", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#most_recent DataHcloudImages#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: bool) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#most_recent DataHcloudImages#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#with_architecture DataHcloudImages#with_architecture}.
        [<CustomOperation "with_architecture">]
        member _.WithArchitecture((), value: seq<string>) =
            assignments.Add("WithArchitecture", box (value |> Seq.toArray))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#with_selector DataHcloudImages#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#with_status DataHcloudImages#with_status}.
        [<CustomOperation "with_status">]
        member _.WithStatus((), value: seq<string>) =
            assignments.Add("WithStatus", box (value |> Seq.toArray))

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudImages.DataHcloudImagesConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudImages.DataHcloudImages(StackContext.get (), logicalId, config)

    let dataHcloudImages logicalId = DataHcloudImagesBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer hcloud_load_balancer}.
    type DataHcloudLoadBalancerBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer#id DataHcloudLoadBalancer#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer#name DataHcloudLoadBalancer#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer#with_selector DataHcloudLoadBalancer#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudLoadBalancer.DataHcloudLoadBalancerConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudLoadBalancer.DataHcloudLoadBalancer(StackContext.get (), logicalId, config)

    let dataHcloudLoadBalancer logicalId =
        DataHcloudLoadBalancerBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer_type hcloud_load_balancer_type}.
    type DataHcloudLoadBalancerTypeBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// ID of the Load Balancer Type.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer_type#id DataHcloudLoadBalancerType#id}
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Name of the Load Balancer Type.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer_type#name DataHcloudLoadBalancerType#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudLoadBalancerType.DataHcloudLoadBalancerTypeConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudLoadBalancerType.DataHcloudLoadBalancerType(StackContext.get (), logicalId, config)

    let dataHcloudLoadBalancerType logicalId =
        DataHcloudLoadBalancerTypeBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer_types hcloud_load_balancer_types}.
    type DataHcloudLoadBalancerTypesBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudLoadBalancerTypes.DataHcloudLoadBalancerTypesConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudLoadBalancerTypes.DataHcloudLoadBalancerTypes(StackContext.get (), logicalId, config)

    let dataHcloudLoadBalancerTypes logicalId =
        DataHcloudLoadBalancerTypesBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancers hcloud_load_balancers}.
    type DataHcloudLoadBalancersBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancers#id DataHcloudLoadBalancers#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancers#with_selector DataHcloudLoadBalancers#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancers(StackContext.get (), logicalId, config)

    let dataHcloudLoadBalancers logicalId =
        DataHcloudLoadBalancersBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/location hcloud_location}.
    type DataHcloudLocationBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// ID of the Location.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/location#id DataHcloudLocation#id}
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Name of the Location.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/location#name DataHcloudLocation#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudLocation.DataHcloudLocationConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudLocation.DataHcloudLocation(StackContext.get (), logicalId, config)

    let dataHcloudLocation logicalId = DataHcloudLocationBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/locations hcloud_locations}.
    type DataHcloudLocationsBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudLocations.DataHcloudLocationsConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudLocations.DataHcloudLocations(StackContext.get (), logicalId, config)

    let dataHcloudLocations logicalId = DataHcloudLocationsBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network hcloud_network}.
    type DataHcloudNetworkBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#id DataHcloudNetwork#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#ip_range DataHcloudNetwork#ip_range}.
        [<CustomOperation "ip_range">]
        member _.IpRange((), value: string) = assignments.Add("IpRange", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#labels DataHcloudNetwork#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#most_recent DataHcloudNetwork#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: bool) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#most_recent DataHcloudNetwork#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#name DataHcloudNetwork#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/network#with_selector DataHcloudNetwork#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudNetwork.DataHcloudNetworkConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudNetwork.DataHcloudNetwork(StackContext.get (), logicalId, config)

    let dataHcloudNetwork logicalId = DataHcloudNetworkBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/networks hcloud_networks}.
    type DataHcloudNetworksBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/networks#id DataHcloudNetworks#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/networks#with_selector DataHcloudNetworks#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudNetworks.DataHcloudNetworksConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudNetworks.DataHcloudNetworks(StackContext.get (), logicalId, config)

    let dataHcloudNetworks logicalId = DataHcloudNetworksBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group hcloud_placement_group}.
    type DataHcloudPlacementGroupBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#id DataHcloudPlacementGroup#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#labels DataHcloudPlacementGroup#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#most_recent DataHcloudPlacementGroup#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: bool) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#most_recent DataHcloudPlacementGroup#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#name DataHcloudPlacementGroup#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#type DataHcloudPlacementGroup#type}.
        [<CustomOperation "type">]
        member _.Type((), value: string) = assignments.Add("Type", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_group#with_selector DataHcloudPlacementGroup#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudPlacementGroup.DataHcloudPlacementGroupConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudPlacementGroup.DataHcloudPlacementGroup(StackContext.get (), logicalId, config)

    let dataHcloudPlacementGroup logicalId =
        DataHcloudPlacementGroupBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups hcloud_placement_groups}.
    type DataHcloudPlacementGroupsBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups#id DataHcloudPlacementGroups#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups#most_recent DataHcloudPlacementGroups#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: bool) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups#most_recent DataHcloudPlacementGroups#most_recent}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "most_recent">]
        member _.MostRecent((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("MostRecent", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/placement_groups#with_selector DataHcloudPlacementGroups#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudPlacementGroups.DataHcloudPlacementGroupsConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudPlacementGroups.DataHcloudPlacementGroups(StackContext.get (), logicalId, config)

    let dataHcloudPlacementGroups logicalId =
        DataHcloudPlacementGroupsBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip hcloud_primary_ip}.
    type DataHcloudPrimaryIpBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#assignee_id DataHcloudPrimaryIp#assignee_id}.
        [<CustomOperation "assignee_id">]
        member _.AssigneeId((), value: double) =
            assignments.Add("AssigneeId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#id DataHcloudPrimaryIp#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#ip_address DataHcloudPrimaryIp#ip_address}.
        [<CustomOperation "ip_address">]
        member _.IpAddress((), value: string) = assignments.Add("IpAddress", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#name DataHcloudPrimaryIp#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ip#with_selector DataHcloudPrimaryIp#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudPrimaryIp.DataHcloudPrimaryIpConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudPrimaryIp.DataHcloudPrimaryIp(StackContext.get (), logicalId, config)

    let dataHcloudPrimaryIp logicalId = DataHcloudPrimaryIpBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ips hcloud_primary_ips}.
    type DataHcloudPrimaryIpsBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ips#id DataHcloudPrimaryIps#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/primary_ips#with_selector DataHcloudPrimaryIps#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudPrimaryIps.DataHcloudPrimaryIpsConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudPrimaryIps.DataHcloudPrimaryIps(StackContext.get (), logicalId, config)

    let dataHcloudPrimaryIps logicalId = DataHcloudPrimaryIpsBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server hcloud_server}.
    type DataHcloudServerBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#id DataHcloudServer#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#name DataHcloudServer#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// network block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#network DataHcloudServer#network}
        /// Accepts: hcloud.IResolvable | hcloud.DataHcloudServer.DataHcloudServerNetwork[]
        [<CustomOperation "network">]
        member _.Network((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Network", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#placement_group_id DataHcloudServer#placement_group_id}.
        [<CustomOperation "placement_group_id">]
        member _.PlacementGroupId((), value: double) =
            assignments.Add("PlacementGroupId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#selector DataHcloudServer#selector}.
        [<CustomOperation "selector">]
        member _.Selector((), value: string) = assignments.Add("Selector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#with_selector DataHcloudServer#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#with_status DataHcloudServer#with_status}.
        [<CustomOperation "with_status">]
        member _.WithStatus((), value: seq<string>) =
            assignments.Add("WithStatus", box (value |> Seq.toArray))

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudServer.DataHcloudServerConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudServer.DataHcloudServer(StackContext.get (), logicalId, config)

    let dataHcloudServer logicalId = DataHcloudServerBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server_type hcloud_server_type}.
    type DataHcloudServerTypeBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// ID of the Server Type.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server_type#id DataHcloudServerType#id}
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Name of the Server Type.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server_type#name DataHcloudServerType#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudServerType.DataHcloudServerTypeConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudServerType.DataHcloudServerType(StackContext.get (), logicalId, config)

    let dataHcloudServerType logicalId = DataHcloudServerTypeBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server_types hcloud_server_types}.
    type DataHcloudServerTypesBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudServerTypes.DataHcloudServerTypesConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudServerTypes.DataHcloudServerTypes(StackContext.get (), logicalId, config)

    let dataHcloudServerTypes logicalId = DataHcloudServerTypesBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/servers hcloud_servers}.
    type DataHcloudServersBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/servers#id DataHcloudServers#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/servers#with_selector DataHcloudServers#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/servers#with_status DataHcloudServers#with_status}.
        [<CustomOperation "with_status">]
        member _.WithStatus((), value: seq<string>) =
            assignments.Add("WithStatus", box (value |> Seq.toArray))

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudServers.DataHcloudServersConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudServers.DataHcloudServers(StackContext.get (), logicalId, config)

    let dataHcloudServers logicalId = DataHcloudServersBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key hcloud_ssh_key}.
    type DataHcloudSshKeyBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Fingerprint of the SSH Key.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#fingerprint DataHcloudSshKey#fingerprint}
        [<CustomOperation "fingerprint">]
        member _.Fingerprint((), value: string) =
            assignments.Add("Fingerprint", box value)

        /// ID of the SSH Key.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#id DataHcloudSshKey#id}
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Name of the SSH Key.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#name DataHcloudSshKey#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#selector DataHcloudSshKey#selector}
        [<CustomOperation "selector">]
        member _.Selector((), value: string) = assignments.Add("Selector", box value)

        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_key#with_selector DataHcloudSshKey#with_selector}
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudSshKey.DataHcloudSshKeyConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudSshKey.DataHcloudSshKey(StackContext.get (), logicalId, config)

    let dataHcloudSshKey logicalId = DataHcloudSshKeyBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_keys hcloud_ssh_keys}.
    type DataHcloudSshKeysBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_keys#id DataHcloudSshKeys#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/ssh_keys#with_selector DataHcloudSshKeys#with_selector}
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudSshKeys.DataHcloudSshKeysConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudSshKeys.DataHcloudSshKeys(StackContext.get (), logicalId, config)

    let dataHcloudSshKeys logicalId = DataHcloudSshKeysBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume hcloud_volume}.
    type DataHcloudVolumeBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#id DataHcloudVolume#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#location DataHcloudVolume#location}.
        [<CustomOperation "location">]
        member _.Location((), value: string) = assignments.Add("Location", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#name DataHcloudVolume#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#selector DataHcloudVolume#selector}.
        [<CustomOperation "selector">]
        member _.Selector((), value: string) = assignments.Add("Selector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#server_id DataHcloudVolume#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#with_selector DataHcloudVolume#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#with_status DataHcloudVolume#with_status}.
        [<CustomOperation "with_status">]
        member _.WithStatus((), value: seq<string>) =
            assignments.Add("WithStatus", box (value |> Seq.toArray))

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudVolume.DataHcloudVolumeConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudVolume.DataHcloudVolume(StackContext.get (), logicalId, config)

    let dataHcloudVolume logicalId = DataHcloudVolumeBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volumes hcloud_volumes}.
    type DataHcloudVolumesBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volumes#id DataHcloudVolumes#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volumes#with_selector DataHcloudVolumes#with_selector}.
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volumes#with_status DataHcloudVolumes#with_status}.
        [<CustomOperation "with_status">]
        member _.WithStatus((), value: seq<string>) =
            assignments.Add("WithStatus", box (value |> Seq.toArray))

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudVolumes.DataHcloudVolumesConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudVolumes.DataHcloudVolumes(StackContext.get (), logicalId, config)

    let dataHcloudVolumes logicalId = DataHcloudVolumesBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone hcloud_zone}.
    type DataHcloudZoneBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// ID of the Zone.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone#id DataHcloudZone#id}
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: double) = assignments.Add("Id", box value)

        /// Name of the Zone.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone#name DataHcloudZone#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone#with_selector DataHcloudZone#with_selector}
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudZone.DataHcloudZoneConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudZone.DataHcloudZone(StackContext.get (), logicalId, config)

    let dataHcloudZone logicalId = DataHcloudZoneBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset hcloud_zone_rrset}.
    type DataHcloudZoneRrsetBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// ID or Name of the parent Zone.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#zone DataHcloudZoneRrset#zone}
        [<CustomOperation "zone">]
        member _.Zone((), value: string) = assignments.Add("Zone", box value)

        /// ID of the Zone RRSet.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#id DataHcloudZoneRrset#id}
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Name of the Zone RRSet.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#name DataHcloudZoneRrset#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Type of the Zone RRSet.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#type DataHcloudZoneRrset#type}
        [<CustomOperation "type">]
        member _.Type((), value: string) = assignments.Add("Type", box value)

        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrset#with_selector DataHcloudZoneRrset#with_selector}
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudZoneRrset.DataHcloudZoneRrsetConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudZoneRrset.DataHcloudZoneRrset(StackContext.get (), logicalId, config)

    let dataHcloudZoneRrset logicalId = DataHcloudZoneRrsetBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets hcloud_zone_rrsets}.
    type DataHcloudZoneRrsetsBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// ID or Name of the parent Zone.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets#zone DataHcloudZoneRrsets#zone}
        [<CustomOperation "zone">]
        member _.Zone((), value: string) = assignments.Add("Zone", box value)

        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zone_rrsets#with_selector DataHcloudZoneRrsets#with_selector}
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudZoneRrsets.DataHcloudZoneRrsetsConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudZoneRrsets.DataHcloudZoneRrsets(StackContext.get (), logicalId, config)

    let dataHcloudZoneRrsets logicalId = DataHcloudZoneRrsetsBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zones hcloud_zones}.
    type DataHcloudZonesBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/zones#with_selector DataHcloudZones#with_selector}
        [<CustomOperation "with_selector">]
        member _.WithSelector((), value: string) =
            assignments.Add("WithSelector", box value)

        member _.Run(_: unit) =
            let config = hcloud.DataHcloudZones.DataHcloudZonesConfig()
            BuilderInternals.apply assignments config
            hcloud.DataHcloudZones.DataHcloudZones(StackContext.get (), logicalId, config)

    let dataHcloudZones logicalId = DataHcloudZonesBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall hcloud_firewall}.
    type FirewallBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#name Firewall#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// apply_to block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#apply_to Firewall#apply_to}
        /// Accepts: hcloud.IResolvable | hcloud.Firewall.FirewallApplyTo[]
        [<CustomOperation "apply_to">]
        member _.ApplyTo((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("ApplyTo", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#id Firewall#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#labels Firewall#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// rule block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall#rule Firewall#rule}
        /// Accepts: hcloud.IResolvable | hcloud.Firewall.FirewallRule[]
        [<CustomOperation "rule">]
        member _.Rule((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Rule", box value)

        member _.Run(_: unit) =
            let config = hcloud.Firewall.FirewallConfig()
            BuilderInternals.apply assignments config
            hcloud.Firewall.Firewall(StackContext.get (), logicalId, config)

    let firewall logicalId = FirewallBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment hcloud_firewall_attachment}.
    type FirewallAttachmentBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment#firewall_id FirewallAttachment#firewall_id}.
        [<CustomOperation "firewall_id">]
        member _.FirewallId((), value: double) =
            assignments.Add("FirewallId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment#id FirewallAttachment#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment#label_selectors FirewallAttachment#label_selectors}.
        [<CustomOperation "label_selectors">]
        member _.LabelSelectors((), value: seq<string>) =
            assignments.Add("LabelSelectors", box (value |> Seq.toArray))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/firewall_attachment#server_ids FirewallAttachment#server_ids}.
        [<CustomOperation "server_ids">]
        member _.ServerIds((), value: seq<double>) =
            assignments.Add("ServerIds", box (value |> Seq.toArray))

        member _.Run(_: unit) =
            let config = hcloud.FirewallAttachment.FirewallAttachmentConfig()
            BuilderInternals.apply assignments config
            hcloud.FirewallAttachment.FirewallAttachment(StackContext.get (), logicalId, config)

    let firewallAttachment logicalId = FirewallAttachmentBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip hcloud_floating_ip}.
    type FloatingIpBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#type FloatingIp#type}.
        [<CustomOperation "type">]
        member _.Type((), value: string) = assignments.Add("Type", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#delete_protection FloatingIp#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: bool) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#delete_protection FloatingIp#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#description FloatingIp#description}.
        [<CustomOperation "description">]
        member _.Description((), value: string) =
            assignments.Add("Description", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#home_location FloatingIp#home_location}.
        [<CustomOperation "home_location">]
        member _.HomeLocation((), value: string) =
            assignments.Add("HomeLocation", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#id FloatingIp#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#labels FloatingIp#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#name FloatingIp#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip#server_id FloatingIp#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        member _.Run(_: unit) =
            let config = hcloud.FloatingIp.FloatingIpConfig()
            BuilderInternals.apply assignments config
            hcloud.FloatingIp.FloatingIp(StackContext.get (), logicalId, config)

    let floatingIp logicalId = FloatingIpBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip_assignment hcloud_floating_ip_assignment}.
    type FloatingIpAssignmentBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip_assignment#floating_ip_id FloatingIpAssignment#floating_ip_id}.
        [<CustomOperation "floating_ip_id">]
        member _.FloatingIpId((), value: double) =
            assignments.Add("FloatingIpId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip_assignment#server_id FloatingIpAssignment#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip_assignment#id FloatingIpAssignment#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        member _.Run(_: unit) =
            let config = hcloud.FloatingIpAssignment.FloatingIpAssignmentConfig()
            BuilderInternals.apply assignments config
            hcloud.FloatingIpAssignment.FloatingIpAssignment(StackContext.get (), logicalId, config)

    let floatingIpAssignment logicalId = FloatingIpAssignmentBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer hcloud_load_balancer}.
    type LoadBalancerBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#load_balancer_type LoadBalancer#load_balancer_type}.
        [<CustomOperation "load_balancer_type">]
        member _.LoadBalancerType((), value: string) =
            assignments.Add("LoadBalancerType", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#name LoadBalancer#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// algorithm block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#algorithm LoadBalancer#algorithm}
        [<CustomOperation "algorithm">]
        member _.Algorithm((), value: hcloud.LoadBalancer.LoadBalancerAlgorithm) =
            assignments.Add("Algorithm", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#delete_protection LoadBalancer#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: bool) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#delete_protection LoadBalancer#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#id LoadBalancer#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#labels LoadBalancer#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#location LoadBalancer#location}.
        [<CustomOperation "location">]
        member _.Location((), value: string) = assignments.Add("Location", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#network_zone LoadBalancer#network_zone}.
        [<CustomOperation "network_zone">]
        member _.NetworkZone((), value: string) =
            assignments.Add("NetworkZone", box value)

        /// target block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#target LoadBalancer#target}
        /// Accepts: hcloud.IResolvable | hcloud.LoadBalancer.LoadBalancerTarget[]
        [<CustomOperation "target">]
        member _.Target((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Target", box value)

        member _.Run(_: unit) =
            let config = hcloud.LoadBalancer.LoadBalancerConfig()
            BuilderInternals.apply assignments config
            hcloud.LoadBalancer.LoadBalancer(StackContext.get (), logicalId, config)

    let loadBalancer logicalId = LoadBalancerBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network hcloud_load_balancer_network}.
    type LoadBalancerNetworkBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#load_balancer_id LoadBalancerNetwork#load_balancer_id}.
        [<CustomOperation "load_balancer_id">]
        member _.LoadBalancerId((), value: double) =
            assignments.Add("LoadBalancerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#enable_public_interface LoadBalancerNetwork#enable_public_interface}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "enable_public_interface">]
        member _.EnablePublicInterface((), value: bool) =
            assignments.Add("EnablePublicInterface", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#enable_public_interface LoadBalancerNetwork#enable_public_interface}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "enable_public_interface">]
        member _.EnablePublicInterface((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("EnablePublicInterface", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#id LoadBalancerNetwork#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#ip LoadBalancerNetwork#ip}.
        [<CustomOperation "ip">]
        member _.Ip((), value: string) = assignments.Add("Ip", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#network_id LoadBalancerNetwork#network_id}.
        [<CustomOperation "network_id">]
        member _.NetworkId((), value: double) = assignments.Add("NetworkId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#subnet_id LoadBalancerNetwork#subnet_id}.
        [<CustomOperation "subnet_id">]
        member _.SubnetId((), value: string) = assignments.Add("SubnetId", box value)

        member _.Run(_: unit) =
            let config = hcloud.LoadBalancerNetwork.LoadBalancerNetworkConfig()
            BuilderInternals.apply assignments config
            hcloud.LoadBalancerNetwork.LoadBalancerNetwork(StackContext.get (), logicalId, config)

    let loadBalancerNetwork logicalId = LoadBalancerNetworkBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service hcloud_load_balancer_service}.
    type LoadBalancerServiceBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#load_balancer_id LoadBalancerService#load_balancer_id}.
        [<CustomOperation "load_balancer_id">]
        member _.LoadBalancerId((), value: string) =
            assignments.Add("LoadBalancerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#protocol LoadBalancerService#protocol}.
        [<CustomOperation "protocol">]
        member _.Protocol((), value: string) = assignments.Add("Protocol", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#destination_port LoadBalancerService#destination_port}.
        [<CustomOperation "destination_port">]
        member _.DestinationPort((), value: double) =
            assignments.Add("DestinationPort", box value)

        /// health_check block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#health_check LoadBalancerService#health_check}
        [<CustomOperation "health_check">]
        member _.HealthCheck((), value: hcloud.LoadBalancerService.LoadBalancerServiceHealthCheck) =
            assignments.Add("HealthCheck", box value)

        /// http block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#http LoadBalancerService#http}
        [<CustomOperation "http">]
        member _.Http((), value: hcloud.LoadBalancerService.LoadBalancerServiceHttp) =
            assignments.Add("Http", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#id LoadBalancerService#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#listen_port LoadBalancerService#listen_port}.
        [<CustomOperation "listen_port">]
        member _.ListenPort((), value: double) =
            assignments.Add("ListenPort", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#proxyprotocol LoadBalancerService#proxyprotocol}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "proxyprotocol">]
        member _.Proxyprotocol((), value: bool) =
            assignments.Add("Proxyprotocol", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#proxyprotocol LoadBalancerService#proxyprotocol}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "proxyprotocol">]
        member _.Proxyprotocol((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("Proxyprotocol", box value)

        member _.Run(_: unit) =
            let config = hcloud.LoadBalancerService.LoadBalancerServiceConfig()
            BuilderInternals.apply assignments config
            hcloud.LoadBalancerService.LoadBalancerService(StackContext.get (), logicalId, config)

    let loadBalancerService logicalId = LoadBalancerServiceBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target hcloud_load_balancer_target}.
    type LoadBalancerTargetABuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#load_balancer_id LoadBalancerTargetA#load_balancer_id}.
        [<CustomOperation "load_balancer_id">]
        member _.LoadBalancerId((), value: double) =
            assignments.Add("LoadBalancerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#type LoadBalancerTargetA#type}.
        [<CustomOperation "type">]
        member _.Type((), value: string) = assignments.Add("Type", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#id LoadBalancerTargetA#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#ip LoadBalancerTargetA#ip}.
        [<CustomOperation "ip">]
        member _.Ip((), value: string) = assignments.Add("Ip", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#label_selector LoadBalancerTargetA#label_selector}.
        [<CustomOperation "label_selector">]
        member _.LabelSelector((), value: string) =
            assignments.Add("LabelSelector", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#server_id LoadBalancerTargetA#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#use_private_ip LoadBalancerTargetA#use_private_ip}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "use_private_ip">]
        member _.UsePrivateIp((), value: bool) =
            assignments.Add("UsePrivateIp", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#use_private_ip LoadBalancerTargetA#use_private_ip}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "use_private_ip">]
        member _.UsePrivateIp((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("UsePrivateIp", box value)

        member _.Run(_: unit) =
            let config = hcloud.LoadBalancerTarget.LoadBalancerTargetAConfig()
            BuilderInternals.apply assignments config
            hcloud.LoadBalancerTarget.LoadBalancerTargetA(StackContext.get (), logicalId, config)

    let loadBalancerTargetA logicalId = LoadBalancerTargetABuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate hcloud_managed_certificate}.
    type ManagedCertificateBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate#domain_names ManagedCertificate#domain_names}.
        [<CustomOperation "domain_names">]
        member _.DomainNames((), value: seq<string>) =
            assignments.Add("DomainNames", box (value |> Seq.toArray))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate#name ManagedCertificate#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate#id ManagedCertificate#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/managed_certificate#labels ManagedCertificate#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        member _.Run(_: unit) =
            let config = hcloud.ManagedCertificate.ManagedCertificateConfig()
            BuilderInternals.apply assignments config
            hcloud.ManagedCertificate.ManagedCertificate(StackContext.get (), logicalId, config)

    let managedCertificate logicalId = ManagedCertificateBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network hcloud_network}.
    type NetworkBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#ip_range Network#ip_range}.
        [<CustomOperation "ip_range">]
        member _.IpRange((), value: string) = assignments.Add("IpRange", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#name Network#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#delete_protection Network#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: bool) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#delete_protection Network#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("DeleteProtection", box value)

        /// Enable or disable exposing the routes to the vSwitch connection.
        /// The exposing only takes effect if a vSwitch connection is active.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#expose_routes_to_vswitch Network#expose_routes_to_vswitch}
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "expose_routes_to_vswitch">]
        member _.ExposeRoutesToVswitch((), value: bool) =
            assignments.Add("ExposeRoutesToVswitch", box value)

        /// Enable or disable exposing the routes to the vSwitch connection.
        /// The exposing only takes effect if a vSwitch connection is active.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#expose_routes_to_vswitch Network#expose_routes_to_vswitch}
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "expose_routes_to_vswitch">]
        member _.ExposeRoutesToVswitch((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("ExposeRoutesToVswitch", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#id Network#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network#labels Network#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        member _.Run(_: unit) =
            let config = hcloud.Network.NetworkConfig()
            BuilderInternals.apply assignments config
            hcloud.Network.Network(StackContext.get (), logicalId, config)

    let network logicalId = NetworkBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route hcloud_network_route}.
    type NetworkRouteBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route#destination NetworkRoute#destination}.
        [<CustomOperation "destination">]
        member _.Destination((), value: string) =
            assignments.Add("Destination", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route#gateway NetworkRoute#gateway}.
        [<CustomOperation "gateway">]
        member _.Gateway((), value: string) = assignments.Add("Gateway", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route#network_id NetworkRoute#network_id}.
        [<CustomOperation "network_id">]
        member _.NetworkId((), value: double) = assignments.Add("NetworkId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_route#id NetworkRoute#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        member _.Run(_: unit) =
            let config = hcloud.NetworkRoute.NetworkRouteConfig()
            BuilderInternals.apply assignments config
            hcloud.NetworkRoute.NetworkRoute(StackContext.get (), logicalId, config)

    let networkRoute logicalId = NetworkRouteBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet hcloud_network_subnet}.
    type NetworkSubnetBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#ip_range NetworkSubnet#ip_range}.
        [<CustomOperation "ip_range">]
        member _.IpRange((), value: string) = assignments.Add("IpRange", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#network_id NetworkSubnet#network_id}.
        [<CustomOperation "network_id">]
        member _.NetworkId((), value: double) = assignments.Add("NetworkId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#network_zone NetworkSubnet#network_zone}.
        [<CustomOperation "network_zone">]
        member _.NetworkZone((), value: string) =
            assignments.Add("NetworkZone", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#type NetworkSubnet#type}.
        [<CustomOperation "type">]
        member _.Type((), value: string) = assignments.Add("Type", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#id NetworkSubnet#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/network_subnet#vswitch_id NetworkSubnet#vswitch_id}.
        [<CustomOperation "vswitch_id">]
        member _.VswitchId((), value: double) = assignments.Add("VswitchId", box value)

        member _.Run(_: unit) =
            let config = hcloud.NetworkSubnet.NetworkSubnetConfig()
            BuilderInternals.apply assignments config
            hcloud.NetworkSubnet.NetworkSubnet(StackContext.get (), logicalId, config)

    let networkSubnet logicalId = NetworkSubnetBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group hcloud_placement_group}.
    type PlacementGroupBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group#name PlacementGroup#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group#type PlacementGroup#type}.
        [<CustomOperation "type">]
        member _.Type((), value: string) = assignments.Add("Type", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group#id PlacementGroup#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/placement_group#labels PlacementGroup#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        member _.Run(_: unit) =
            let config = hcloud.PlacementGroup.PlacementGroupConfig()
            BuilderInternals.apply assignments config
            hcloud.PlacementGroup.PlacementGroup(StackContext.get (), logicalId, config)

    let placementGroup logicalId = PlacementGroupBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip hcloud_primary_ip}.
    type PrimaryIpBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#assignee_type PrimaryIp#assignee_type}.
        [<CustomOperation "assignee_type">]
        member _.AssigneeType((), value: string) =
            assignments.Add("AssigneeType", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#auto_delete PrimaryIp#auto_delete}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "auto_delete">]
        member _.AutoDelete((), value: bool) =
            assignments.Add("AutoDelete", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#auto_delete PrimaryIp#auto_delete}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "auto_delete">]
        member _.AutoDelete((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("AutoDelete", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#type PrimaryIp#type}.
        [<CustomOperation "type">]
        member _.Type((), value: string) = assignments.Add("Type", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#assignee_id PrimaryIp#assignee_id}.
        [<CustomOperation "assignee_id">]
        member _.AssigneeId((), value: double) =
            assignments.Add("AssigneeId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#datacenter PrimaryIp#datacenter}.
        [<CustomOperation "datacenter">]
        member _.Datacenter((), value: string) =
            assignments.Add("Datacenter", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#delete_protection PrimaryIp#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: bool) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#delete_protection PrimaryIp#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#id PrimaryIp#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#labels PrimaryIp#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#name PrimaryIp#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        member _.Run(_: unit) =
            let config = hcloud.PrimaryIp.PrimaryIpConfig()
            BuilderInternals.apply assignments config
            hcloud.PrimaryIp.PrimaryIp(StackContext.get (), logicalId, config)

    let primaryIp logicalId = PrimaryIpBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs hcloud}.
    type HcloudProviderBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Alias name.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#alias HcloudProvider#alias}
        [<CustomOperation "alias">]
        member _.Alias((), value: string) = assignments.Add("Alias", box value)

        /// The Hetzner Cloud API endpoint, can be used to override the default API Endpoint https://api.hetzner.cloud/v1.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#endpoint HcloudProvider#endpoint}
        [<CustomOperation "endpoint">]
        member _.Endpoint((), value: string) = assignments.Add("Endpoint", box value)

        /// The type of function to be used during the polling.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_function HcloudProvider#poll_function}
        [<CustomOperation "poll_function">]
        member _.PollFunction((), value: string) =
            assignments.Add("PollFunction", box value)

        /// The interval at which actions are polled by the client.
        /// Default `500ms`. Increase this interval if you run into rate limiting errors.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#poll_interval HcloudProvider#poll_interval}
        [<CustomOperation "poll_interval">]
        member _.PollInterval((), value: string) =
            assignments.Add("PollInterval", box value)

        /// The Hetzner Cloud API token, can also be specified with the HCLOUD_TOKEN environment variable.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs#token HcloudProvider#token}
        [<CustomOperation "token">]
        member _.Token((), value: string) = assignments.Add("Token", box value)

        member _.Run(_: unit) =
            let config = hcloud.Provider.HcloudProviderConfig()
            BuilderInternals.apply assignments config
            hcloud.Provider.HcloudProvider(StackContext.get (), logicalId, config)

    let provider logicalId = HcloudProviderBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns hcloud_rdns}.
    type RdnsBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#dns_ptr Rdns#dns_ptr}.
        [<CustomOperation "dns_ptr">]
        member _.DnsPtr((), value: string) = assignments.Add("DnsPtr", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#ip_address Rdns#ip_address}.
        [<CustomOperation "ip_address">]
        member _.IpAddress((), value: string) = assignments.Add("IpAddress", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#floating_ip_id Rdns#floating_ip_id}.
        [<CustomOperation "floating_ip_id">]
        member _.FloatingIpId((), value: double) =
            assignments.Add("FloatingIpId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#id Rdns#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#load_balancer_id Rdns#load_balancer_id}.
        [<CustomOperation "load_balancer_id">]
        member _.LoadBalancerId((), value: double) =
            assignments.Add("LoadBalancerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#primary_ip_id Rdns#primary_ip_id}.
        [<CustomOperation "primary_ip_id">]
        member _.PrimaryIpId((), value: double) =
            assignments.Add("PrimaryIpId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/rdns#server_id Rdns#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        member _.Run(_: unit) =
            let config = hcloud.Rdns.RdnsConfig()
            BuilderInternals.apply assignments config
            hcloud.Rdns.Rdns(StackContext.get (), logicalId, config)

    let rdns logicalId = RdnsBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server hcloud_server}.
    type ServerBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#name Server#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#server_type Server#server_type}.
        [<CustomOperation "server_type">]
        member _.ServerType((), value: string) =
            assignments.Add("ServerType", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#allow_deprecated_images Server#allow_deprecated_images}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "allow_deprecated_images">]
        member _.AllowDeprecatedImages((), value: bool) =
            assignments.Add("AllowDeprecatedImages", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#allow_deprecated_images Server#allow_deprecated_images}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "allow_deprecated_images">]
        member _.AllowDeprecatedImages((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("AllowDeprecatedImages", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#backups Server#backups}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "backups">]
        member _.Backups((), value: bool) = assignments.Add("Backups", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#backups Server#backups}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "backups">]
        member _.Backups((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Backups", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#datacenter Server#datacenter}.
        [<CustomOperation "datacenter">]
        member _.Datacenter((), value: string) =
            assignments.Add("Datacenter", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#delete_protection Server#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: bool) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#delete_protection Server#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#firewall_ids Server#firewall_ids}.
        [<CustomOperation "firewall_ids">]
        member _.FirewallIds((), value: seq<double>) =
            assignments.Add("FirewallIds", box (value |> Seq.toArray))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#id Server#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ignore_remote_firewall_ids Server#ignore_remote_firewall_ids}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "ignore_remote_firewall_ids">]
        member _.IgnoreRemoteFirewallIds((), value: bool) =
            assignments.Add("IgnoreRemoteFirewallIds", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ignore_remote_firewall_ids Server#ignore_remote_firewall_ids}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "ignore_remote_firewall_ids">]
        member _.IgnoreRemoteFirewallIds((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("IgnoreRemoteFirewallIds", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#image Server#image}.
        [<CustomOperation "image">]
        member _.Image((), value: string) = assignments.Add("Image", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#iso Server#iso}.
        [<CustomOperation "iso">]
        member _.Iso((), value: string) = assignments.Add("Iso", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#keep_disk Server#keep_disk}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "keep_disk">]
        member _.KeepDisk((), value: bool) = assignments.Add("KeepDisk", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#keep_disk Server#keep_disk}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "keep_disk">]
        member _.KeepDisk((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("KeepDisk", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#labels Server#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#location Server#location}.
        [<CustomOperation "location">]
        member _.Location((), value: string) = assignments.Add("Location", box value)

        /// network block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#network Server#network}
        /// Accepts: hcloud.IResolvable | hcloud.Server.ServerNetwork[]
        [<CustomOperation "network">]
        member _.Network((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Network", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#placement_group_id Server#placement_group_id}.
        [<CustomOperation "placement_group_id">]
        member _.PlacementGroupId((), value: double) =
            assignments.Add("PlacementGroupId", box value)

        /// public_net block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#public_net Server#public_net}
        /// Accepts: hcloud.IResolvable | hcloud.Server.ServerPublicNet[]
        [<CustomOperation "public_net">]
        member _.PublicNet((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("PublicNet", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#rebuild_protection Server#rebuild_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "rebuild_protection">]
        member _.RebuildProtection((), value: bool) =
            assignments.Add("RebuildProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#rebuild_protection Server#rebuild_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "rebuild_protection">]
        member _.RebuildProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("RebuildProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#rescue Server#rescue}.
        [<CustomOperation "rescue">]
        member _.Rescue((), value: string) = assignments.Add("Rescue", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#shutdown_before_deletion Server#shutdown_before_deletion}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "shutdown_before_deletion">]
        member _.ShutdownBeforeDeletion((), value: bool) =
            assignments.Add("ShutdownBeforeDeletion", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#shutdown_before_deletion Server#shutdown_before_deletion}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "shutdown_before_deletion">]
        member _.ShutdownBeforeDeletion((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("ShutdownBeforeDeletion", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#ssh_keys Server#ssh_keys}.
        [<CustomOperation "ssh_keys">]
        member _.SshKeys((), value: seq<string>) =
            assignments.Add("SshKeys", box (value |> Seq.toArray))

        /// timeouts block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#timeouts Server#timeouts}
        [<CustomOperation "timeouts">]
        member _.Timeouts((), value: hcloud.Server.ServerTimeouts) = assignments.Add("Timeouts", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server#user_data Server#user_data}.
        [<CustomOperation "user_data">]
        member _.UserData((), value: string) = assignments.Add("UserData", box value)

        member _.Run(_: unit) =
            let config = hcloud.Server.ServerConfig()
            BuilderInternals.apply assignments config
            hcloud.Server.Server(StackContext.get (), logicalId, config)

    let server logicalId = ServerBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network hcloud_server_network}.
    type ServerNetworkABuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#server_id ServerNetworkA#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#alias_ips ServerNetworkA#alias_ips}.
        [<CustomOperation "alias_ips">]
        member _.AliasIps((), value: seq<string>) =
            assignments.Add("AliasIps", box (value |> Seq.toArray))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#id ServerNetworkA#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#ip ServerNetworkA#ip}.
        [<CustomOperation "ip">]
        member _.Ip((), value: string) = assignments.Add("Ip", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#network_id ServerNetworkA#network_id}.
        [<CustomOperation "network_id">]
        member _.NetworkId((), value: double) = assignments.Add("NetworkId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#subnet_id ServerNetworkA#subnet_id}.
        [<CustomOperation "subnet_id">]
        member _.SubnetId((), value: string) = assignments.Add("SubnetId", box value)

        member _.Run(_: unit) =
            let config = hcloud.ServerNetwork.ServerNetworkAConfig()
            BuilderInternals.apply assignments config
            hcloud.ServerNetwork.ServerNetworkA(StackContext.get (), logicalId, config)

    let serverNetworkA logicalId = ServerNetworkABuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot hcloud_snapshot}.
    type SnapshotBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#server_id Snapshot#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#description Snapshot#description}.
        [<CustomOperation "description">]
        member _.Description((), value: string) =
            assignments.Add("Description", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#id Snapshot#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#labels Snapshot#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// timeouts block.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/snapshot#timeouts Snapshot#timeouts}
        [<CustomOperation "timeouts">]
        member _.Timeouts((), value: hcloud.Snapshot.SnapshotTimeouts) = assignments.Add("Timeouts", box value)

        member _.Run(_: unit) =
            let config = hcloud.Snapshot.SnapshotConfig()
            BuilderInternals.apply assignments config
            hcloud.Snapshot.Snapshot(StackContext.get (), logicalId, config)

    let snapshot logicalId = SnapshotBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/ssh_key hcloud_ssh_key}.
    type SshKeyBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Name of the SSH Key.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/ssh_key#name SshKey#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Public key of the SSH Key pair.
        /// If this is a file, it can be read using the `file` interpolation function.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/ssh_key#public_key SshKey#public_key}
        [<CustomOperation "public_key">]
        member _.PublicKey((), value: string) = assignments.Add("PublicKey", box value)

        /// User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/ssh_key#labels SshKey#labels}
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        member _.Run(_: unit) =
            let config = hcloud.SshKey.SshKeyConfig()
            BuilderInternals.apply assignments config
            hcloud.SshKey.SshKey(StackContext.get (), logicalId, config)

    let sshKey logicalId = SshKeyBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate hcloud_uploaded_certificate}.
    type UploadedCertificateBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#certificate UploadedCertificate#certificate}.
        [<CustomOperation "certificate">]
        member _.Certificate((), value: string) =
            assignments.Add("Certificate", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#name UploadedCertificate#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#private_key UploadedCertificate#private_key}.
        [<CustomOperation "private_key">]
        member _.PrivateKey((), value: string) =
            assignments.Add("PrivateKey", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#id UploadedCertificate#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/uploaded_certificate#labels UploadedCertificate#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        member _.Run(_: unit) =
            let config = hcloud.UploadedCertificate.UploadedCertificateConfig()
            BuilderInternals.apply assignments config
            hcloud.UploadedCertificate.UploadedCertificate(StackContext.get (), logicalId, config)

    let uploadedCertificate logicalId = UploadedCertificateBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume hcloud_volume}.
    type VolumeBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#name Volume#name}.
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#size Volume#size}.
        [<CustomOperation "size">]
        member _.Size((), value: double) = assignments.Add("Size", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#automount Volume#automount}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "automount">]
        member _.Automount((), value: bool) = assignments.Add("Automount", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#automount Volume#automount}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "automount">]
        member _.Automount((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Automount", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#delete_protection Volume#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: bool) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#delete_protection Volume#delete_protection}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("DeleteProtection", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#format Volume#format}.
        [<CustomOperation "format">]
        member _.Format((), value: string) = assignments.Add("Format", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#id Volume#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#labels Volume#labels}.
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#location Volume#location}.
        [<CustomOperation "location">]
        member _.Location((), value: string) = assignments.Add("Location", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume#server_id Volume#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        member _.Run(_: unit) =
            let config = hcloud.Volume.VolumeConfig()
            BuilderInternals.apply assignments config
            hcloud.Volume.Volume(StackContext.get (), logicalId, config)

    let volume logicalId = VolumeBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment hcloud_volume_attachment}.
    type VolumeAttachmentBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#server_id VolumeAttachment#server_id}.
        [<CustomOperation "server_id">]
        member _.ServerId((), value: double) = assignments.Add("ServerId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#volume_id VolumeAttachment#volume_id}.
        [<CustomOperation "volume_id">]
        member _.VolumeId((), value: double) = assignments.Add("VolumeId", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#automount VolumeAttachment#automount}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "automount">]
        member _.Automount((), value: bool) = assignments.Add("Automount", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#automount VolumeAttachment#automount}.
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "automount">]
        member _.Automount((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Automount", box value)

        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/volume_attachment#id VolumeAttachment#id}.
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        [<CustomOperation "id">]
        member _.Id((), value: string) = assignments.Add("Id", box value)

        member _.Run(_: unit) =
            let config = hcloud.VolumeAttachment.VolumeAttachmentConfig()
            BuilderInternals.apply assignments config
            hcloud.VolumeAttachment.VolumeAttachment(StackContext.get (), logicalId, config)

    let volumeAttachment logicalId = VolumeAttachmentBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone hcloud_zone}.
    type ZoneBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Mode of the Zone.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#mode Zone#mode}
        [<CustomOperation "mode">]
        member _.Mode((), value: string) = assignments.Add("Mode", box value)

        /// Name of the Zone.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#name Zone#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Whether delete protection is enabled.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#delete_protection Zone#delete_protection}
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: bool) =
            assignments.Add("DeleteProtection", box value)

        /// Whether delete protection is enabled.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#delete_protection Zone#delete_protection}
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("DeleteProtection", box value)

        /// User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#labels Zone#labels}
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Primary nameservers of the Zone. Forbidden when mode is primary and required when mode is secondary.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#primary_nameservers Zone#primary_nameservers}
        /// Accepts: hcloud.IResolvable | hcloud.Zone.ZonePrimaryNameservers[]
        [<CustomOperation "primary_nameservers">]
        member _.PrimaryNameservers((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("PrimaryNameservers", box value)

        /// Default Time To Live (TTL) of the Zone.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone#ttl Zone#ttl}
        [<CustomOperation "ttl">]
        member _.Ttl((), value: double) = assignments.Add("Ttl", box value)

        member _.Run(_: unit) =
            let config = hcloud.Zone.ZoneConfig()
            BuilderInternals.apply assignments config
            hcloud.Zone.Zone(StackContext.get (), logicalId, config)

    let zone logicalId = ZoneBuilder(logicalId)

    /// Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset hcloud_zone_rrset}.
    type ZoneRrsetBuilder(logicalId: string) =
        let assignments = ResizeArray<string * obj>()
        member _.Yield(_: unit) = ()
        member _.Zero(()) = ()

        /// Name of the Zone RRSet.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#name ZoneRrset#name}
        [<CustomOperation "name">]
        member _.Name((), value: string) = assignments.Add("Name", box value)

        /// Records of the Zone RRSet.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#records ZoneRrset#records}
        /// Accepts: hcloud.IResolvable | hcloud.ZoneRrset.ZoneRrsetRecords[]
        [<CustomOperation "records">]
        member _.Records((), value: HashiCorp.Cdktf.IResolvable) = assignments.Add("Records", box value)

        /// Type of the Zone RRSet.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#type ZoneRrset#type}
        [<CustomOperation "type">]
        member _.Type((), value: string) = assignments.Add("Type", box value)

        /// ID or Name of the parent Zone.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#zone ZoneRrset#zone}
        [<CustomOperation "zone">]
        member _.Zone((), value: string) = assignments.Add("Zone", box value)

        /// Whether change protection is enabled.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#change_protection ZoneRrset#change_protection}
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "change_protection">]
        member _.ChangeProtection((), value: bool) =
            assignments.Add("ChangeProtection", box value)

        /// Whether change protection is enabled.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#change_protection ZoneRrset#change_protection}
        /// Accepts: boolean | hcloud.IResolvable
        [<CustomOperation "change_protection">]
        member _.ChangeProtection((), value: HashiCorp.Cdktf.IResolvable) =
            assignments.Add("ChangeProtection", box value)

        /// User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#labels ZoneRrset#labels}
        [<CustomOperation "labels">]
        member _.Labels((), value: seq<string * string>) =
            assignments.Add("Labels", box (dict value))

        /// Time To Live (TTL) of the Zone RRSet.
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/zone_rrset#ttl ZoneRrset#ttl}
        [<CustomOperation "ttl">]
        member _.Ttl((), value: double) = assignments.Add("Ttl", box value)

        member _.Run(_: unit) =
            let config = hcloud.ZoneRrset.ZoneRrsetConfig()
            BuilderInternals.apply assignments config
            hcloud.ZoneRrset.ZoneRrset(StackContext.get (), logicalId, config)

    let zoneRrset logicalId = ZoneRrsetBuilder(logicalId)
