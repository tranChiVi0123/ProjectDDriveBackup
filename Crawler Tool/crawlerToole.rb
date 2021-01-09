require 'Mechanize'
require 'json'
#Khởi tạo object
agent = Mechanize.new

#Fetch page
page = agent.get("https://kipalog.com/posts/pagination?filter=top&page=76")
url = "https://kipalog.com/"

result = JSON.parse(page.body)

p result[0]["path"]

contentUrl = url + result[0]["path"] 

content = agent.get(contentUrl)

p content.at('#content').text
