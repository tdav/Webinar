# Txt

dotnet ef dbcontext scaffold "Server=localhost;Database=ef;User=root;Password=123456;TreatTinyAsBoolean=true;" "Pomelo.EntityFrameworkCore.MySql"


package rdf

import (
	"encoding/xml"
)

type RDF struct {
	XMLName xml.Name `xml:"RDF"`
	Channel *Channel `xml:"channel"`
	Item    []*Item  `xml:"item"`
}

type Channel struct {
	Title       string `xml:"title"`
	Description string `xml:"description"`
	Link        string `xml:"link"`
	Date        string `xml:"date"`
}

type Item struct {
	About       string `xml:"about,attr"`
	Format      string `xml:"format"`
	Date        string `xml:"date"`
	Source      string `xml:"source"`
	Creator     string `xml:"creator"`
	Title       string `xml:"title"`
	Link        string `xml:"link"`
	Description string `xml:"description"`
	Content     string `xml:"encoded"`
}