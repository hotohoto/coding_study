counter = {}

print("종료하려면 값을 입력하지 않고 엔터만 누르세요.")
while True:
  val = input("입력 값:")
  if val == "":
    break

  if val in counter:
    counter[val] += 1
  else:
    counter[val] = 1

maxCount = 0
maxKey = None

for k in counter:
  # print(k, counter[k])
  if maxCount < counter[k]:
    maxCount = counter[k]
    maxKey = k

print('제일 많이 나온 값은 {} 이며 {}회 입니다.'.format(maxKey, maxCount))